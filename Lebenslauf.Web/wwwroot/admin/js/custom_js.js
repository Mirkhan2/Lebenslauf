$(document).ready(function () {
    $('.data-table').DataTable({
        language: {
            "emptyTable": "Esgibt keine Daten",
            "info": "Schauen _START_ Bis _END_ Von _TOTAL_ Column",
            "infoEmpty": "Zeige 0 bis 0 von 0 Zeilen",
            "infoFiltered": "(Filter   _MAX_ Column)",
            "infoThousands": ",",
            "lengthMenu": "Schauen _MENU_ ",
            "processing": ".Verarbeitung..",
            "search": "Suchen:",
            "zeroRecords": "Mit diesen Angaben wurde kein Datensatz gefunden.",
            "paginate": {
                "next": "Bevor",
                "previous": "Nachste",
                "first": "Erste",
                "last": "Letze"
            },
            "aria": {
                "sortAscending": ":Aufsteigende Anzeige aktivieren ",
                "sortDescending": ": Absteigende Anzeige aktivieren"
            },
            "autoFill": {
                "cancel": "Stornierung",
                "fill": "Alle Zellen mit Systemstruktur füllen",
                "fillHorizontal": "Zelle horizontal füllen",
                "fillVertical": "Zelle vertikal füllen"
            },
            "buttons": {
                "collection": "Sammlung",
                "colvis": "Spaltenanzeigefähigkeit",
                "colvisRestore": "Anzeigefähigkeit zurücksetzen",
                "copy": "Kopie",
                "copySuccess": {
                    "1": "Eine Zeile wurde in den Speicher kopiert",
                    "_": "%ds Zeilen in den Speicher kopiert"
                },
                "copyTitle": "In den Speicher kopieren",
                "excel": "Excel",
                "pageLength": {
                    "-1": "Alle Zeilen anzeigen",
                    "_": "Zeige % d Zeilen"
                },
                "print": "Ausdrucken",
                "copyKeys": "Drücken Sie Strg oder ⌘ + C, um die Tabellendaten in den Systemspeicher zu kopieren.",
                "csv": "Ordner CSV",
                "pdf": "Ordner PDF",
                "renameState": "Umbenennen",
                "updateState": "Aktualisieren"
            },
            "searchBuilder": {
                "add": "Bedingung hinzufügen",
                "button": {
                    "0": "Suchmaschine",
                    "_": "Suchmaschine (%d)"
                },
                "clearAll": "Alles leeren",
                "condition": "Zustand",
                "conditions": {
                    "date": {
                        "after": "Nach",
                        "before": "Nach",
                        "between": "Zwischen",
                        "empty": "frei",
                        "equals": "Gleich",
                        "not": "Nicht",
                        "notBetween": "Nicht zwischen",
                        "notEmpty": "Nicht leer"
                    },
                    "number": {
                        "between": "Zwischen",
                        "empty": "Leer",
                        "equals": "Gleich",
                        "gt": "Größer als",
                        "gte": "Gleich oder größer als",
                        "lt": "weniger als ",
                        "lte": "Gleich oder kleiner als",
                        "not": "Nicht zu sein",
                        "notBetween": "Nicht zwischen",
                        "notEmpty": "Nicht leer"
                    },
                    "string": {
                        "contains": "Enthält",
                        "empty": "frei",
                        "endsWith": "Endet mit",
                        "equals": "Gleich",
                        "not": "Nicht",
                        "notEmpty": "Nicht leer",
                        "startsWith": "Beginnen mit",
                        "notContains": "Enthält nicht",
                        "notEnds": "Endet nicht mit",
                        "notStarts": "Beginnen Sie nicht mit"
                    },
                    "array": {
                        "equals": "Gleich",
                        "empty": "Leer",
                        "contains": "Enthält",
                        "not": "Nicht",
                        "notEmpty": "Nicht leer",
                        "without": "Ohne"
                    }
                },
                "data": "Information",
                "logicAnd": "und",
                "logicOr": "Oder",
                "title": {
                    "0": "Suchmaschine",
                    "_": "Suchmaschine (%d)"
                },
                "value": "Menge",
                "deleteTitle": "Filterbedingung löschen",
                "leftTitle": "Äußerer Zustand",
                "rightTitle": "Innerer Zustand"
            },
            "select": {
                "cells": {
                    "1": "1 Zelle ausgewählt",
                    "_": "Zelle ausgewählt"
                },
                "columns": {
                    "1": "Eine Spalte wurde ausgewählt",
                    "_": "%d Spalte ausgewählt"
                },
                "rows": {
                    "1": "1 Zeile ausgewählt",
                    "_": "%d Ausgewalt"
                }
            },
            "thousands": ",",
            "searchPanes": {
                "clearMessage": "Loschen alle",
                "collapse": {
                    "0": " Suche",
                    "_": " suche (٪ d)"
                },
                "count": "{total}",
                "countFiltered": "{shown} ({total})",
                "emptyPanes": "Suchseite existiert nicht",
                "loadMessage": "Suchseiten werden geladen...",
                "title": "Aktive Filter – %d",
                "showMessage": "Alle anzeigen"
            },
            "loadingRecords": "Laden...",
            "datetime": {
                "previous": "Bevor",
                "next": "Nachste",
                "hours": "Uhr",
                "minutes": "Minuten",
                "seconds": "Sekunde",
                "amPm": [
                    "Vormittag",
                    "Abend"
                ],
                "months": {
                    "0": "januar",
                    "1": "Februar",
                    "10": "November",
                    "2": "Marz",
                    "4": "Mai",
                    "6": "Juli",
                    "8": "September",
                    "11": "December",
                    "3": "April",
                    "5": "juni",
                    "7": "august",
                    "9": "october"
                },
                "unknown": "-",
                "weekdays": [
                    "Sonntag",
                    "Montag",
                    "سه‌Dienstag",
                    "Mittwoch",
                    "Donnerstag",
                    "Fraitag",
                    "Samstag"
                ]
            },
            "editor": {
                "close": "schlissen",
                "create": {
                    "button": "Neue",
                    "title": "Neue Registrierung",
                    "submit": "Erstellen"
                },
                "edit": {
                    "button": "Bearbeiten",
                    "title": "Bearbeiten",
                    "submit": "Aktuelisirung"
                },
                "remove": {
                    "button": "Loschen",
                    "title": "Loschen",
                    "submit": "Loschen",
                    "confirm": {
                        "_": "Möchten Sie wirklich %d Zeilen löschen?",
                        "1": "Möchten Sie wirklich eine Zeile löschen?"
                    }
                },
                "multi": {
                    "restore": "Zurück",
                    "noMulti": "Dieser Eintrag kann einzeln bearbeitet werden, jedoch nicht als Teil einer Gruppe."
                }
            },
            "decimal": ".",
            "stateRestore": {
                "creationModal": {
                    "button": "Erstellen",
                    "columns": {
                        "search": "Spaltensuche",
                        "visible": "Spaltenanzeigestatus"
                    },
                    "name": "Name:",
                    "order": "Sortierung",
                    "paging": "Pagination",
                    "search": "Suchen",
                    "select": "Auswahl",
                    "title": "Eine neue Situation schaffen",
                    "toggleLabel": "Umfasst:"
                },
                "emptyError": "Name darf nicht leer sein.",
                "removeConfirm": "Möchten Sie %s wirklich löschen?",
                "removeJoiner": "Loschenو",
                "removeSubmit": "Loschen",
                "renameButton": " Wechseln Name",
                "renameLabel": "Neue Name Fur $s :"
            }
        },
    });
});


function StartLoading(element = 'body') {
    $(element).waitMe({
        effect: 'bounce',
        text: 'Warten Sie Bitte ...',
        bg: 'rgba(255, 255, 255, 0.7)',
        color: '#000'
    });
}

function CloseLoading(element = 'body') {
    $(element).waitMe('hide');
}


function LoadThingIDoFormModal(id) {
    $.ajax({
        url: "/Admin/ThingIDo/LoadThingIDoFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#ThingIDoForm').data('validator', null);
            $.validator.unobtrusive.parse("#ThingIDoForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function ThingIDoFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Erfolgfreich einsatzد.', ' Erfolgreich Nachricht', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Error Einsatz', ' Error nachricht', 'error')
    }

}

function DeleteThingIDo(id) {
    swal.fire({
        title: "Warning",
        text: "SInd sie sicher um loschen ؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'Loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/ThingIDo/DeleteThingIDO",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Einsatz Erfolgreich.', 'Erfolgreich', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('EInsatz nicht erfolgreich', ' Error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}



function LoadEducationFormModal(id) {
    $.ajax({
        url: "/Admin/Education/LoadEducationFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#EducationForm').data('validator', null);
            $.validator.unobtrusive.parse("#EducationForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function EducationFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Der Vorgang war erfolgreich.', ' Erfolgreich', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen.', ' Error', 'error')
    }

}

function DeleteEducation(id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'Loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/Education/DeleteEducation",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich.', 'Erfolgreich ', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('عDer Vorgang ist fehlgeschlagen', 'Error ', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}


function LoadCustomerFeedbackFormModal(id) {
    $.ajax({
        url: "/Admin/CustomerFeedback/LoadCustomrFeedbackFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#CustomerFeedbackForm').data('validator', null);
            $.validator.unobtrusive.parse("#CustomerFeedbackForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function CustomerFeedbackFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Der Vorgang ist fehlgeschlagen..', ' Erfolgreich', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen', ' Eror ','error')
    }

}

function DeleteCustomerFeedback(id) {
    swal.fire({
        title: "Warning",
        text: "Möchten Sie diesen Artikel wirklich löschen?؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'loschen',
        denyButtonText: 'nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/CustomerFeedback/DeleteCustomerFeedback",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich..', 'Erfolgreich ', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('Der Vorgang ist fehlgeschlagen..', '= Error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}



function LoadSkillFormModal(id) {
    $.ajax({
        url: "/Admin/Skill/LoadSkillFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#SkillForm').data('validator', null);
            $.validator.unobtrusive.parse("#SkillForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function SkillFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('عDer Vorgang war erfolgreich.', ' Erfolgreich', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen.', ' Error', 'error')
    }

}

function DeleteSkill(id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'Loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/Skill/DeleteSkill",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich.', ' Erfolgreich', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('Der Vorgang ist fehlgeschlagen..', ' Error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}




function LoadPortfolioCategoryFormModal(id) {
    $.ajax({
        url: "/Admin/PortfolioCategory/LoadPortfolioCategoryFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#PortfolioCategoryForm').data('validator', null);
            $.validator.unobtrusive.parse("#PortfolioCategorySkillForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function PortfolioCategoryFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Der Vorgang war erfolgreich.', ' Erfolgreich', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen.', ' Error', 'error')
    }

}

function DeletePortfolioCategory(id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/PortfolioCategory/DeletePortfolioCategory",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich', 'Erfolgreich ', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('Der Vorgang ist fehlgeschlagen..', ' Error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}



function LoadPortfolioFormModal(id) {
    $.ajax({
        url: "/Admin/Portfolio/LoadPortfolioFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#PortfolioForm').data('validator', null);
            $.validator.unobtrusive.parse("#PortfolioSkillForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function PortfolioFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Der Vorgang war erfolgreich.', 'Erfolreich ', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen.', 'Error ', 'error')
    }

}

function DeletePortfolio(id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/Portfolio/DeletePortfolio",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich.', 'Erfolgreich ', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('Der Vorgang ist fehlgeschlagen..', ' error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}



function LoadInformationFormModal() {
    $.ajax({
        url: "/Admin/Information/LoadInformationFormModal",
        type: "get",
        data: {
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-left-content").html(res);

            $('#InformationForm').data('validator', null);
            $.validator.unobtrusive.parse("#InformationForm");

            $('#modal-left').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function InformationFormSubmited(res) {
    CloseLoading();

    if (res.status === 'Success') {
        ShowMessage('Der Vorgang war erfolgreich    .', 'erfolgreich ', 'success')
        $('#modal-left').modal('hide');
        $('#data-table-box').load(location.href + ' #data-table-box');
        $.getScript('/admin/js/data-table.js', function (data, textStatus, jqxhr) { });
    } else {
        showMessage('Der Vorgang ist fehlgeschlagen.', ' error', 'error')
    }

}


function DeleteMessage(id) {
    swal.fire({
        title: "Warnung",
        text: "Möchten Sie diesen Artikel wirklich löschen?",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'Loschen',
        denyButtonText: 'Nein'
    }).then((willDelete) => {
        if (willDelete.isConfirmed) {

            $.ajax({
                url: "/Admin/Message/DeleteMessage",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();

                    if (res.status === "Success") {
                        ShowMessage('Der Vorgang war erfolgreich.', ' Erfolgreich', 'success');
                        $(`#ListItem-${id}`).remove();
                    } else {
                        ShowMessage('Der Vorgang ist fehlgeschlagen.', ' Error', 'error');
                    }

                },
                error: function () {
                    CloseLoading();
                }
            });

        }
    });
}