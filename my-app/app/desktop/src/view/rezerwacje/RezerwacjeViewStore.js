Ext.define('MyExtGenApp.view.rezerwacje.RezerwacjeViewStore', {
    extend: 'Ext.data.Store',
    alias: 'store.rezerwacjeviewstore',
    fields: [
        'KodRezerwacji', 'DataUtworzenia', 'Cena', 'DataZameldowania', 'DataWymeldowania', 'Waluta', 'Id', 'Prowizja', 'Zrodlo'
    ],
    autoLoad: true,

    /*
    groupField: 'dept',
    data: { items: [
        { name: 'Jean Luc',   email: "jeanluc.picard@enterprise.com", phone: "555-111-1111", dept: "bridge" },
        { name: 'ModernWorf', email: "worf.moghsson@enterprise.com",  phone: "555-222-2222", dept: "engine" },
        { name: 'Deanna',     email: "deanna.troi@enterprise.com",    phone: "555-333-3333", dept: "bridge" },
        { name: 'Data',       email: "mr.data@enterprise.com",        phone: "555-444-4444", dept: "bridge" }
    ]},
    */

    proxy: {
        type: 'rest',
        url: 'https://localhost:44382/rezerwacje',
        reader: {
            type: 'json',
            rootProperty: 'data'
        }
    }
});
