namespace Velocium.Network.Responses;

public class VComResponse
{
    public string ResponseId { get; set;  }
    public VCode Code { get; set;  }
    public string Message { get; set;  }
}

public enum VCode
{
    Success = 1,
    BadRequest = 2,
    NotFound = 3,
    InternalServerError = 4,
}