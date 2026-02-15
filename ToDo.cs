namespace knightmoves;

public class ToDo
{
    public string[] MarkAsDone(string[] todos)
    {
        int index = 0;

        foreach (var todo in todos)
        {
            todos[index] = "done - " + todo;
            index++;
        }

        return todos;
    }
}
