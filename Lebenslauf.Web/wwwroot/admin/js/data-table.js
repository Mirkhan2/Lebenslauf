$(document).ready(function () {
    $('.data-table').DataTable({
        language: {
            "emptyTable": "Die Tabelle enthält keine Daten.",
            "info": "schauen _START_ تا _END_ از _TOTAL_ Reihe",
            "infoEmpty": "Shauen 0 bis 0 von 0 Reihe",
            "infoFiltered": "(Gefiltert nach _MAX_ Reihe)",
            "infoThousands": ",",
            "lengthMenu": " Zeigen_MENU_ Reihe",
            "processing": "Verarbeitung...",
            "search": "Suche:",
            "zeroRecords": "Mit diesen Angaben wurde kein Datensatz gefunden.",
            "paginate": {
                "next": "nachste",
                "previous": "bevor",
                "first": "Erste",
                "last": "Letyte"
            },
            "aria": {
                "sortAscending": ":Aufsteigende Anzeige aktivieren ",
                "sortDescending": ": Aussteigende Anzeige aktivieren  "
            },
            "autoFill": {
                "cancel": "Stornierung",
                "fill": "Füllen aller Zellen mit Systemstruktur",
                "fillHorizontal": "Füllen Sie eine Zelle horizontal",
                "fillVertical": "Eine Zelle vertikal füllen"
            },
            "buttons": {
                "collection": "Sammlung",
                "colvis": "Spaltenanzeigefunktion",
                "colvisRestore": "Anzeigefunktion zurücksetzen",
                "copy": "Kopieren",
                "copySuccess": {
                    "1": "Eine Zeile wurde in den Speicher kopiert.",
                    "_": "%ds Die Zeile im Speicher wurde kopiert."
                },
                "copyTitle": "In den Speicher kopieren",
                "excel": "Excel",
                "pageLength": {
                    "-1": "Alle Zeilen anzeigen",
                    "_": "Zeige %d Zeilen"
                },
                "print": "Drucken",
                "copyKeys": "Um Tabellendaten in den Systemspeicher zu kopieren, drücken Sie die Tasten ctrl Oder ⌘ + CDrücken ",
                "csv": "File CSV",
                "pdf": "File PDF",
                "renameState": "Namen ändern",
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
                        "after": "bevor",
                        "before": " nach",
                        "between": "Zwischen",
                        "empty": "Leer",
                        "equals": "Equal",
                        "not": "nicht",
                        "notBetween": "nicht zwischen",
                        "notEmpty": "nicht leer "
                    },
                    "number": {
                        "between": "Zweischen",
                        "empty": "Leer",
                        "equals": "Equal",
                        "gt": "bigger als ",
                        "gte": "   Equal oder grosser",
                        "lt": " kleiner als",
                        "lte": " equal oder kliner als",
                        "not": "nicht",
                        "notBetween": " nicht zwischen",
                        "notEmpty": " nicht leer"
                    },
                    "string": {
                        "contains": "Enthält",
                        "empty": "Leer",
                        "endsWith": "Endet mit",
                        "equals": "Equal",
                        "not": "nicht",
                        "notEmpty": "Nicht leer.",
                        "startsWith": "Beginnen Sie mit",
                        "notContains": "Enthält nicht",
                        "notEnds": "Es endet nicht mit",
                        "notStarts": "Beginnen Sie nicht mit"
                    },
                    "array": {
                        "equals": "Equal",
                        "empty": "Leer",
                        "contains": "enthalt",
                        "not": "nicht",
                        "notEmpty": "nicht leer",
                        "without": "Ohne"
                    }
                },
                "data": "Information",
                "logicAnd": "und",
                "logicOr": "oder",
                "title": {
                    "0": "SUchmaschine",
                    "_": "sUchmachine (%d)"
                },
                "value": "Menge",
                "deleteTitle": "  Zustand menge enthalt",
                "leftTitle": " zustand draussen",
                "rightTitle": "zustand drinnen "
            },
            "select": {
                "cells": {
                    "1": "1Zelle ausgewählt. ",
                    "_": "%d Zelle ausgewählt.  "
                },
                "columns": {
                    "1": "Eine Spalte wurde ausgewählt.",
                    "_": "%dSpalte ausgewählt."
                },
                "rows": {
                    "1": "1Zeile ausgewählt.",
                    "_": "%d Ausgewählt"
                }
            },
            "thousands": ",",
            "searchPanes": {
                "clearMessage": "Alles löschen.",
                "collapse": {
                    "0": "Suchseite",
                    "_": "Suchseite (٪ d)"
                },
                "count": "{total}",
                "countFiltered": "{shown} ({total})",
                "emptyPanes": "Die Suchseite existiert nicht.",
                "loadMessage": " Suchseiten werden geladen...",
                "title": "Aktive Filter - %d",
                "showMessage":"ale Shaue"
            },
            "loadingRecords": "Laden...",
            "datetime": {
                "previous": "Vorherige",
                "next": "nachste",
                "hours": "Stunde",
                "minutes": "min",
                "seconds": "Sek",
                "amPm": [
                    "Morgen",
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
                    "11": "Dezember",
                    "3": "April",
                    "5": "Juni",
                    "7": "august",
                    "9": "October"
                },
                "unknown": "-",
                "weekdays": [
                    "Sonntag",
                    "montag",
                    "DIenstag‌",
                    "Mittwoch",
                    "Donnerstag",
                    "Fritag",
                    "Samstag"
                ]
            },
            "editor": {
                "close": "Loschen",
                "create": {
                    "button": "Neue",
                    "title": " Neue Submitt",
                    "submit": "Schaffung"
                },
                "edit": {
                    "button": "Bearbeiten",
                    "title": "Bearbeiten",
                    "submit": "Aktualisieren"
                },
                "remove": {
                    "button": "loschen",
                    "title": "loschen",
                    "submit": "loschen",
                    "confirm": {
                        "_": "  Möchten Sie wirklich %d Zeilen löschen?",
                        "1": "Möchten Sie wirklich eine Zeile löschen?؟"
                    }
                },
                "multi": {
                    "restore": "Rückgängig machen",
                    "noMulti": "Dieser Eintrag kann einzeln bearbeitet werden, jedoch nicht als Teil einer Gruppe."
                }
            },
            "decimal": ".",
            "stateRestore": {
                "creationModal": {
                    "button": "Schaffung",
                    "columns": {
                        "search": "Spaltensuche",
                        "visible": "Spaltenanzeigestatus"
                    },
                    "name": "name:",
                    "order": "Sortierung",
                    "paging": "Pagination",
                    "search": "Suche",
                    "select": "Auswahl",
                    "title": "Neuen Status erstellen",
                    "toggleLabel": ":Enthält"
                },
                "emptyError": "Der Name darf nicht leer sein.",
                "removeConfirm": "Möchten Sie %s wirklich löschen?",
                "removeJoiner": "und",
                "removeSubmit": "loschen",
                "renameButton": "Namen ändern",
                "renameLabel": "„Neuer Name für $s :"
            }
        },
    });
});
