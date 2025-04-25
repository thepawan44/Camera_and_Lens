using System.Collections.Generic;

namespace UI.Shared.UtilityHelpers.Wrapper;

public interface IResponse
{
    string? Messages { get; set; }

    bool Succeeded { get; set; }
}

public interface IResponse<out T> : IResponse
{
    T Data { get; }
}