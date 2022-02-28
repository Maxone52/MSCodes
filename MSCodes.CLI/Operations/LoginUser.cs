namespace MSCodes.CLI.Operations
{
    public class LoginUser : IOperation
    {
        public string Name => "Login into the system";

        public void Execute()
        {
            Console.Write("Введите ваш email");
            string? email = Console.ReadLine();
            User? user = UserStorage.Get(email);

            if (user == null)
            {
                UserSession.CurrentUser = user;
            }
        }
    }
}
