using Client.Services;
using Database.Context;
using Database.Controllers;
using Database.Repositories;

EntryContext entryContext = new EntryContext();

EntryRepository entryRepository = new EntryRepository(entryContext);
MenuRepository menuRepository = new MenuRepository(entryContext);

EntryController entryController = new EntryController(entryRepository);
MenuController menuController = new MenuController(menuRepository);

EntryService entryService = new EntryService(entryController);
MenuService menuService = new MenuService(menuController);