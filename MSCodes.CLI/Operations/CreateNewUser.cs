public class CreateNewUser : IOperation
{
    public string Name => "Create new user";

    public void Execute()
    {

        Console.Write("Введите ваш email:");
        string? email = Console.ReadLine();

        User newUser = new User
        {
            Email = email
        };

        bool userCreated = UserStorage.Create(newUser);

        if (!userCreated)
        {
            Console.WriteLine("Пользователь с таким email уже есть");
        }

        Console.WriteLine("Пользователь был успешно создан");
    }
}
