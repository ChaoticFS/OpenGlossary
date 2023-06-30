using Database.Context;
using Database.Services;

EntryContext entryContext = new EntryContext();

EntryService entryService = new EntryService(entryContext);
MenuService menuService = new MenuService(entryContext);

