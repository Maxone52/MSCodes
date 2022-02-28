using System.Net;

public class Menu
{
    private IOperation[] _operations;

    public Menu(IOperation[] operation)
    {
        _operations = operation;
    }

    public string[] GetOperationNames()
    {
        List<string> operationNames = new();

        for (int i = 0; i < _operations.Length; i++)
        {
            IOperation operation = _operations[i];
            operationNames.Add($"{i} - {operation.Name}");
        }

        return operationNames.ToArray();
    }

    public void Enter(int operationNumber)
    {
        if (operationNumber < 0 || operationNumber >= _operations.Length)
        {
            return;
        }

        _operations[operationNumber].Execute();
    }
}
