function StartLoading(element = 'body') {
    $(element).waitMe({
        effect: 'bounce',
        text: 'Bitte warten...', 
        bg: 'rgba(255, 255, 255, 0.7)',
        color: '#000'
    });
}

function CloseLoading(element = 'body') {
    $(element).waitMe('hide');
}

function OpenModalAjax(url, id, formSelector) {
    $.ajax({
        url: url,
        type: "GET",
        data: { id: id },
        beforeSend: function () { StartLoading(); }, 
        success: function (res) {
            CloseLoading();
            $("#modal-left-content").html(res);

            if (formSelector) {
                $(formSelector).data('validator', null);
                $.validator.unobtrusive.parse(formSelector);
            }

            $('#modal-left').modal('show');
        },
        error: function () {
            CloseLoading();
            ShowMessage("Error", "Ein Serverfehler ist aufgetreten.", "error");
        }
    });
}

function HandleAjaxSubmitResponse(res) {
    CloseLoading();

    var status = res.status ? res.status.trim() : "Error";

    if (status === 'Success') {
        ShowMessage('Erfolgreich', 'Der Vorgang war erfolgreich.', 'success');
        $('#modal-left').modal('hide');

        setTimeout(function () {
            window.location.reload();
        }, 1000);
    } else {
        ShowMessage('Error', 'Der Vorgang ist fehlgeschlagen.', 'error');
    }
}

function DeleteAjaxGeneric(url, id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Löschen',
        cancelButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {
            $.ajax({
                url: url,
                type: "GET", 
                data: { id: id },
                beforeSend: function () { StartLoading(); },
                success: function (res) {
                    CloseLoading();
                    var status = res.status ? res.status.trim() : "Error";
                    if (status === "Success") {
                        ShowMessage('Erfolgreich', 'Der Vorgang war erfolgreich.', 'success');
                        $(`#ListItem-${id}`).fadeOut(500, function () { $(this).remove(); });
                    } else {
                        ShowMessage('Error', 'Der Vorgang ist fehlgeschlagen.', 'error');
                    }
                },
                error: function () {
                    CloseLoading();
                    ShowMessage('Error', 'Ein Serverfehler ist aufgetreten.', 'error');
                }
            });
        }
    });
}


function LoadThingIDoFormModal(id) { OpenModalAjax("/Admin/ThingIDo/LoadThingIDoFormModal", id, "#ThingIDoForm"); }
function ThingIDoFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteThingIDo(id) { DeleteAjaxGeneric("/Admin/ThingIDo/DeleteThingIDO", id); }

function LoadEducationFormModal(id) { OpenModalAjax("/Admin/Education/LoadEducationFormModal", id, "#EducationForm"); }
function EducationFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteEducation(id) { DeleteAjaxGeneric("/Admin/Education/DeleteEducation", id); }
function LoadCustomerFeedbackFormModal(id) {
    OpenModalAjax("/Admin/CustomerFeedback/LoadCustomerFeedbackFormModal", id, "#CustomerFeedbackForm");
}
function CustomerFeedbackFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteCustomerFeedback(id) { DeleteAjaxGeneric("/Admin/CustomerFeedback/DeleteCustomerFeedback", id); }

function LoadSkillFormModal(id) { OpenModalAjax("/Admin/Skill/LoadSkillFormModal", id, "#SkillForm"); }
function SkillFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteSkill(id) { DeleteAjaxGeneric("/Admin/Skill/DeleteSkill", id); }

function LoadPortfolioCategoryFormModal(id) {
    OpenModalAjax("/Admin/PortfolioCategory/LoadPortfolioCategoryFormModal", id, "#PortfolioCategoryForm");
}
function PortfolioCategoryFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeletePortfolioCategory(id) { DeleteAjaxGeneric("/Admin/PortfolioCategory/DeletePortfolioCategory", id); }

function LoadPortfolioFormModal(id) {
    OpenModalAjax("/Admin/Portfolio/LoadPortfolioFormModal", id, "#PortfolioForm");
}
function PortfolioFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeletePortfolio(id) { DeleteAjaxGeneric("/Admin/Portfolio/DeletePortfolio", id); }

function LoadInformationFormModal() { OpenModalAjax("/Admin/Information/LoadInformationFormModal", 0, "#InformationForm"); }
function InformationFormSubmited(res) { HandleAjaxSubmitResponse(res); }

function DeleteMessage(id) { DeleteAjaxGeneric("/Admin/Message/DeleteMessage", id); }
function LoadErfahrungFormModal(id) { OpenModalAjax("/Admin/Erfahrung/LoadErfahrungFormModal", id, "#ErfahrungForm"); }
function ErfahrungFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteErfahrung(id) { DeleteAjaxGeneric("/Admin/Erfahrung/DeleteErfahrung", id); }
// CustomerLogo
function LoadCustomerLogoFormModal(id) { OpenModalAjax("/Admin/CustomerLogo/LoadCustomerLogoFormModal", id, "#CustomerLogoForm"); }
function CustomerLogoFormSubmited(res) { HandleAjaxSubmitResponse(res); }
function DeleteCustomerLogo(id) { DeleteAjaxGeneric("/Admin/CustomerLogo/DeleteCustomerLogo", id); }