namespace TodoApi.Model;


public class TodoItem
{

	public uint TodoItemId { get; set; }
	public string? Task { get; set; }
	public string? Instructions { get; set; }

	public DateTime Deadline {get;set;}

	public DateTime Assigned {get;set;}
	public bool IsComplete { get; set; } = false;


}