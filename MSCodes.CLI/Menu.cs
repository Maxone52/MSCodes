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
        List<string> operationNames = new List<string>();

        foreach (IOperation operation in _operations)
        {
            operationNames.Add(operation.Name)
        }

        return operationNames.ToArray();
    }
}
