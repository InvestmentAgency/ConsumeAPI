namespace ConsumeAPI;

public class ApiResponse
{
    public string data { get; set; }
    public bool success { get; set; }
    public int statusCode { get; set; }
    public List<string> messages { get; set; }
    public object details { get; set; }
}
