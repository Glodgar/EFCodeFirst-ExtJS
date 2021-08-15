Ext.define('MyExtGenApp.view.rezerwacje.RezerwacjeViewStore', {
    extend: 'Ext.data.Store',
    alias: 'store.rezerwacjeviewstore',
    fields: [
        'KodRezerwacji', 'DataUtworzenia', 'Cena', 'DataZameldowania', 'DataWymeldowania', 'Waluta', 'Id', 'Prowizja', 'Zrodlo'
    ],
    autoLoad: true,
    
    proxy: {
        type: 'rest',
        url: 'https://localhost:44382/rezerwacje',
        reader: {
            type: 'json',
            rootProperty: 'data'
        }
    }
});
