using MSCodes.CLI.Operations;

IOperation[] operation = new IOperation[]
{
    new CreateNewUser(),
    new LoginUser()
};

Menu menu = new Menu(operation);

Application application = new(menu);
application.Run();