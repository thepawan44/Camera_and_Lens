using UI.Shared.Component.Enums.Color;

namespace UI.Shared.Component.Preload;

public class PreloadService
{
    #region Events

    internal event Action OnHide;
    internal event Action<SpinnerColor> OnShow;

    #endregion

    #region Methods

    public void Hide() => OnHide?.Invoke();

    public void Show(SpinnerColor spinnerColor = SpinnerColor.Light) => OnShow?.Invoke(spinnerColor);

    #endregion
}
