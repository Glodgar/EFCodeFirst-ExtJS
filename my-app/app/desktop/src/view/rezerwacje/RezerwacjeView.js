Ext.define('MyExtGenApp.view.rezerwacje.RezerwacjeView',{
    extend: 'Ext.grid.Grid',
    xtype: 'rezerwacjeview',
    cls: 'rezerwacjeview',
    requires: ['Ext.grid.rowedit.Plugin'],
    controller: {type: 'rezerwacjeviewcontroller'},
    viewModel: {type: 'rezerwacjeviewmodel'},
    store: {type: 'rezerwacjeviewstore'},
    grouped: true,
    groupFooter: {
        xtype: 'gridsummaryrow'
    },
    plugins: {
        rowedit: {
            autoConfirm: false
        }
    },
    columns: [
        {
            text: 'KodRezerwacji',
            dataIndex: 'kodRezerwacji',
            editable: true,
            width: 100,
            cell: {userCls: 'bold'}
        },
        {
            text: 'DataUtworzenia',
            dataIndex: 'dataUtworzenia',
            editable: true, 
            width: 230
        },
        {
            text: 'Cena',
            dataIndex: 'cena',
            editable: true,
            width: 150
        },
        {
            text: 'DataZameldowania',
            dataIndex: 'dataZameldowania',
            editable: true,
            width: 150
        },
        {
            text: 'DataWymeldowania',
            dataIndex: 'dataWymeldowania',
            editable: true,
            width: 150
        },
        {
            text: 'Waluta',
            dataIndex: 'waluta',
            editable: true,
            width: 150
        },
        {
            text: 'Id',
            dataIndex: 'id',
            editable: true,
            width: 150
        },
        {
            text: 'Prowizja',
            dataIndex: 'prowizja',
            editable: true,
            width: 150
        },
        {
            text: 'Zrodlo',
            dataIndex: 'zrodlo',
            editable: true,
            width: 150
        }

    ],
    listeners: {
        canceledit: 'onEditCancelled'
    }
});
