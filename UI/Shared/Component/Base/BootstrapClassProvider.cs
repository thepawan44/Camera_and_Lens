using UI.Shared.Component.Enums;
using UI.Shared.Component.Enums.Color;

namespace UI.Shared.Component.Base;

public class BootstrapClassProvider
{
    #region Methods

    public string Accordion() => "accordion";
    public string AccordionButton() => $"{Accordion()}-button";
    public string AccordionFlush() => $"{Accordion()}-flush";
    public string AccordionItem() => $"{Accordion()}-item";
    public string AccordionItemBody() => $"{Accordion()}-body";
    public string AccordionItemHeader() => $"{Accordion()}-header";

    public string Active() => "active";

    public string Alert() => "alert";

    public string AlertColor(AlertColor color) => $"{Alert()}-{ToAlertColor(color)}";

    public string? AlertDescription() => null;

    public string AlertDismisable() => "alert-dismissible";

    public string AlertFade() => Fade();

    public string? AlertHasDescription() => null;

    public string? AlertHasMessage() => null;

    public string? AlertMessage() => null;

    public string AlertShow() => Show();

    public string BackgroundColor(BackgroundColor backgroundColor) => $"bg-{ToBackgroundColor(backgroundColor)}";

    public string Badge() => "badge";

    public string BadgeColor(BadgeColor color) => $"text-bg-{ToBadgeColor(color)}";

    public string Button() => "btn";

    public string ButtonActive() => "active";

    public string ButtonBlock() => $"{Button()}-block";

    public string ButtonColor(ButtonColor color) => $"{Button()}-{ToButtonColor(color)}";

    public string ButtonDisabled() => "disabled";

    public string ButtonGroup() => $"{Button()}-group";

    public string? ButtonLoading() => null;

    public string ButtonOutline(ButtonColor color) => color != Enums.Color.ButtonColor.None ? $"{Button()}-outline-{ToButtonColor(color)}" : $"{Button()}-outline";

    public string ButtonSize(Size size) => $"{Button()}-{ToSize(size)}";

    public string Callout() => "bb-callout";

    public string CalloutHeading() => $"{Callout()}-heading";

    public string Card() => "card";
    public string CardBody() => $"{Card()}-body";
    public string CardFooter() => $"{Card()}-footer";
    public string CardGroup() => $"{Card()}-group";
    public string CardHeader() => $"{Card()}-header";
    public string CardLink() => $"{Card()}-link";
    public string CardSubTitle() => $"{Card()}-subtitle";
    public string CardText() => $"{Card()}-text";
    public string CardTitle() => $"{Card()}-title";

    public string Checks() => "form-check-input";
    public string ChecksReverse() => "form-check-reverse";

    public string Collapse() => "collapse";

    public string Collapsed() => "collapsed";
    public string CollapseHorizontal() => $"{Collapse()}-horizontal";

    public string ConfirmationModal() => "modal-confirmation";

    public string Disabled() => "disabled";

    public string DisplayHeadingSize(DisplayHeadingSize displayHeadingSize) => $"display-{ToDisplayHeadingSize(displayHeadingSize)}";

    public string Divider() => "divider";

    public string DividerType(DividerType dividerType) => $"{Divider()}-{ToDividerType(dividerType)}";

    public string Dropdown() => "dropdown";

    public string DropdownDirection(DropdownDirection direction) => ToDropdownDirection(direction);
    public string DropdownDivider() => $"{Dropdown()}-divider";
    public string DropdownHeader() => $"{Dropdown()}-header";
    public string DropdownItem() => $"{Dropdown()}-item";
    public string DropdownMenu() => $"{Dropdown()}-menu";
    public string DropdownMenuPosition(DropdownMenuPosition position) => ToDropdownMenuPosition(position);
    public string DropdownToggle() => $"{Dropdown()}-toggle";
    public string DropdownToggleSplit() => $"{DropdownToggle()}-split";

    public string Fade() => "fade";

    public string FlexAlignment(Alignment alignment) => $"justify-content-{ToAlignment(alignment)}";

    public string FormControl() => "form-control";

    public string HeadingSize(HeadingSize headingSize) => $"h{ToHeadingSize(headingSize)}";

    public string IconColor(IconColor iconColor) => $"text-{ToIconColor(iconColor)}";

    public string IsInValid() => "invalid";

    public string IsValid() => "valid";

    public string Modal() => "modal";

    public string ModalFade() => Fade();

    public string ModalHeader(ModalType modalType) => $"text-bg-{ToModalTypeColor(modalType)} border-bottom {ToModalHeaderBottomBorderColor(modalType)}";

    public string Offcanvas() => "offcanvas";

    public string Offcanvas(Placement placement) => $"{Offcanvas()}-{ToPlacement(placement)}";

    public string PageLoadingModal() => "modal-page-loading";

    public string Pagination() => "pagination";

    public string PaginationItem() => "page-item";

    public string PaginationItemActive() => Active();

    public string PaginationItemDisabled() => Disabled();

    public string PaginationLink() => "page-link";

    public string? PaginationLinkActive() => null;

    public string? PaginationLinkDisabled() => null;

    public string PaginationSize(PaginationSize size) => $"{Pagination()}-{ToPaginationSize(size)}";

    public string PillBadge() => "rounded-pill";

    public string Placeholder() => "placeholder";
    public string PlaceholderAnimation(PlaceholderAnimation animation) => $"{Placeholder()}-{ToPlaceholderAnimation(animation)}";
    public string PlaceholderColor(PlaceholderColor color) => $"bg-{ToPlaceholderColor(color)}";
    public string PlaceholderSize(PlaceholderSize size) => $"{Placeholder()}-{ToPlaceholderSize(size)}";
    public string PlaceholderWidth(PlaceholderWidth width) => $"{ToPlaceholderWidth(width)}";

    public string Position() => "position";
    public string PositionAbsolute() => $"{Position()}-absolute";
    public string PositionFixed() => $"{Position()}-fixed";
    public string PositionRelative() => $"{Position()}-relative";
    public string PositionStatic() => $"{Position()}-static";
    public string PositionSticky() => $"{Position()}-sticky";

    public string Progress() => "progress";
    public string ProgressBackgroundColor(ProgressColor color) => $"bg-{ToProgressColor(color)}";
    public string ProgressBar() => $"{Progress()}-bar";
    public string ProgressBarAnimated() => $"{ProgressBar()}-animated";
    public string ProgressBarStriped() => $"{ProgressBar()}-striped";

    public string Show() => "show";

    public string TextAlignment(Alignment alignment) => $"text-{ToAlignment(alignment)}";

    public string TextAndBackgroundColor(BackgroundColor backgroundColor) => $"text-bg-{ToBackgroundColor(backgroundColor)}";

    public string TextColor(TextColor textColor) => $"text-{ToTextColor(textColor)}";

    public string TextNoWrap() => "text-nowrap";

    public string ToAlertColor(AlertColor color) =>
        color switch
        {
            Enums.Color.AlertColor.Primary => "primary",
            Enums.Color.AlertColor.Secondary => "secondary",
            Enums.Color.AlertColor.Success => "success",
            Enums.Color.AlertColor.Danger => "danger",
            Enums.Color.AlertColor.Warning => "warning",
            Enums.Color.AlertColor.Info => "info",
            Enums.Color.AlertColor.Light => "light",
            Enums.Color.AlertColor.Dark => "dark",
            _ => null
        };

    public string ToAlignment(Alignment alignment) =>
        alignment switch
        {
            Alignment.Start => "start",
            Alignment.Center => "center",
            Alignment.End => "end",
            _ => null
        };

    public string Toast() => "toast";
    public string ToastContainer() => $"{Toast()}-container";

    public string ToAutoCompleteSize(AutoCompleteSize size) =>
        size switch
        {
            AutoCompleteSize.Large => "form-control-lg",
            AutoCompleteSize.Small => "form-control-sm",
            _ => ""
        };

    public string ToBackgroundColor(BackgroundColor color) =>
        color switch
        {
            Enums.BackgroundColor.Primary => "primary",
            Enums.BackgroundColor.Secondary => "secondary",
            Enums.BackgroundColor.Success => "success",
            Enums.BackgroundColor.Danger => "danger",
            Enums.BackgroundColor.Warning => "warning",
            Enums.BackgroundColor.Info => "info",
            Enums.BackgroundColor.Light => "light",
            Enums.BackgroundColor.Dark => "dark",
            Enums.BackgroundColor.Body => "body",
            Enums.BackgroundColor.White => "white",
            Enums.BackgroundColor.Transparent => "transparent",
            _ => null
        };

    public string ToBadgeColor(BadgeColor color) =>
        color switch
        {
            Enums.Color.BadgeColor.Primary => "primary",
            Enums.Color.BadgeColor.Secondary => "secondary",
            Enums.Color.BadgeColor.Success => "success",
            Enums.Color.BadgeColor.Danger => "danger",
            Enums.Color.BadgeColor.Warning => "warning",
            Enums.Color.BadgeColor.Info => "info",
            Enums.Color.BadgeColor.Light => "light",
            Enums.Color.BadgeColor.Dark => "dark",
            _ => null
        };

    public string ToBadgeIndicator(BadgeIndicatorType indicatorType) =>
        indicatorType switch
        {
            BadgeIndicatorType.RoundedPill => "rounded-pill",
            BadgeIndicatorType.RoundedCircle => "rounded-circle",
            _ => "" // default: Top right
        };

    public string ToBadgePlacement(BadgePlacement badgePlacement) =>
        badgePlacement switch
        {
            BadgePlacement.TopLeft => "top-0 start-0 translate-middle",
            BadgePlacement.TopCenter => "top-0 start-50 translate-middle",
            BadgePlacement.TopRight => "top-0 start-100 translate-middle",
            BadgePlacement.MiddleLeft => "top-50 start-0 translate-middle",
            BadgePlacement.MiddleCenter => "top-50 start-50 translate-middle",
            BadgePlacement.MiddleRight => "top-50 start-100 translate-middle",
            BadgePlacement.BottomLeft => "top-100 start-0 translate-middle",
            BadgePlacement.BottomCenter => "top-100 start-50 translate-middle",
            BadgePlacement.BottomRight => "top-100 start-100 translate-middle",
            _ => "top-0 start-100 translate-middle" // default: Top right
        };

    public string ToButtonColor(ButtonColor color) =>
        color switch
        {
            Enums.Color.ButtonColor.Primary => "primary",
            Enums.Color.ButtonColor.Secondary => "secondary",
            Enums.Color.ButtonColor.Success => "success",
            Enums.Color.ButtonColor.Danger => "danger",
            Enums.Color.ButtonColor.Warning => "warning",
            Enums.Color.ButtonColor.Info => "info",
            Enums.Color.ButtonColor.Light => "light",
            Enums.Color.ButtonColor.Dark => "dark",
            Enums.Color.ButtonColor.Link => "link",
            _ => null
        };

    public string ToCalloutType(CalloutType type) =>
        type switch
        {
            CalloutType.Default => "",
            CalloutType.Danger => $"{Callout()}-danger",
            CalloutType.Warning => $"{Callout()}-warning",
            CalloutType.Info => $"{Callout()}-info",
            CalloutType.Tip => $"{Callout()}-success",
            _ => ""
        };

    public string ToCardColor(CardColor color) =>
        color switch
        {
            CardColor.Primary => "text-bg-primary",
            CardColor.Secondary => "text-bg-secondary",
            CardColor.Success => "text-bg-success",
            CardColor.Danger => "text-bg-danger",
            CardColor.Warning => "text-bg-warning",
            CardColor.Info => "text-bg-info",
            CardColor.Light => "text-bg-light",
            CardColor.Dark => "text-bg-dark",
            _ => ""
        };

    public string ToColor(TextColor color) =>
        color switch
        {
            Enums.Color.TextColor.Primary => "primary",
            Enums.Color.TextColor.Secondary => "secondary",
            Enums.Color.TextColor.Success => "success",
            Enums.Color.TextColor.Danger => "danger",
            Enums.Color.TextColor.Warning => "warning",
            Enums.Color.TextColor.Info => "info",
            Enums.Color.TextColor.Light => "light",
            Enums.Color.TextColor.Dark => "dark",
            _ => null
        };

    public string ToDialogSize(DialogSize size) =>
        size switch
        {
            DialogSize.Regular => null,
            DialogSize.Small => "modal-sm",
            DialogSize.Large => "modal-lg",
            DialogSize.ExtraLarge => "modal-xl",
            _ => null
        };

    public string ToDisplayHeadingSize(DisplayHeadingSize displayHeadingSize) =>
        displayHeadingSize switch
        {
            Enums.DisplayHeadingSize.H1 => "1",
            Enums.DisplayHeadingSize.H2 => "2",
            Enums.DisplayHeadingSize.H3 => "3",
            Enums.DisplayHeadingSize.H4 => "4",
            _ => null
        };

    public string ToDividerType(DividerType dividerType) =>
        dividerType switch
        {
            Enums.DividerType.Dashed => "dashed",
            Enums.DividerType.Dotted => "dotted",
            Enums.DividerType.TextContent => "text",
            _ => "solid"
        };

    public string ToDropdownDirection(DropdownDirection direction) =>
        direction switch
        {
            Enums.DropdownDirection.Dropdown => "dropdown",
            Enums.DropdownDirection.DropdownCentered => "dropdown dropdown-center",
            Enums.DropdownDirection.Dropend => "dropend",
            Enums.DropdownDirection.Dropup => "dropup",
            Enums.DropdownDirection.DropupCentered => "dropup dropup-center",
            Enums.DropdownDirection.Dropstart => "dropstart",
            _ => ""
        };

    public string ToDropdownMenuPosition(DropdownMenuPosition position) =>
        position switch
        {
            Enums.DropdownMenuPosition.Start => "dropdown-menu-start",
            Enums.DropdownMenuPosition.End => "dropdown-menu-end",
            _ => ""
        };

    public string ToHeadingSize(HeadingSize headingSize) =>
        headingSize switch
        {
            Enums.HeadingSize.H1 => "1",
            Enums.HeadingSize.H2 => "2",
            Enums.HeadingSize.H3 => "3",
            Enums.HeadingSize.H4 => "4",
            Enums.HeadingSize.H5 => "5",
            Enums.HeadingSize.H6 => "6",
            _ => null
        };

    public string ToIconColor(IconColor color) =>
        color switch
        {
            Enums.Color.IconColor.Primary => "primary",
            Enums.Color.IconColor.Secondary => "secondary",
            Enums.Color.IconColor.Success => "success",
            Enums.Color.IconColor.Danger => "danger",
            Enums.Color.IconColor.Warning => "warning",
            Enums.Color.IconColor.Info => "info",
            Enums.Color.IconColor.Light => "light",
            Enums.Color.IconColor.Dark => "dark",
            Enums.Color.IconColor.Body => "body",
            Enums.Color.IconColor.Muted => "muted",
            Enums.Color.IconColor.White => "white",
            _ => null
        };

    public string ToModalFullscreen(ModalFullscreen fullscreen) =>
        fullscreen switch
        {
            ModalFullscreen.Disabled => null,
            ModalFullscreen.Always => "modal-fullscreen",
            ModalFullscreen.SmallDown => "modal-fullscreen-sm-down",
            ModalFullscreen.MediumDown => "modal-fullscreen-md-down",
            ModalFullscreen.LargeDown => "modal-fullscreen-lg-down",
            ModalFullscreen.ExtraLargeDown => "modal-fullscreen-xl-down",
            ModalFullscreen.ExtraExtraLargeDown => "modal-fullscreen-xxl-down",
            _ => null
        };

    public string ToModalHeaderBottomBorderColor(ModalType modalType) =>
        modalType switch
        {
            ModalType.Primary => "border-primary",
            ModalType.Secondary => "border-secondary",
            ModalType.Success => "border-success",
            ModalType.Danger => "border-danger",
            ModalType.Warning => "border-warning",
            ModalType.Info => "border-info",
            ModalType.Light => null,
            ModalType.Dark => "border-dark",
            _ => null
        };

    public string ToModalSize(ModalSize size) =>
        size switch
        {
            ModalSize.Regular => null,
            ModalSize.Small => "modal-sm",
            ModalSize.Large => "modal-lg",
            ModalSize.ExtraLarge => "modal-xl",
            _ => null
        };

    public string ToModalTypeColor(ModalType modalType) =>
        modalType switch
        {
            ModalType.Primary => "primary",
            ModalType.Secondary => "secondary",
            ModalType.Success => "success",
            ModalType.Danger => "danger",
            ModalType.Warning => "warning",
            ModalType.Info => "info",
            ModalType.Light => "light",
            ModalType.Dark => "dark",
            _ => null
        };

    public string ToOffcanvasSize(OffcanvasSize size) =>
        size switch
        {
            OffcanvasSize.Regular => null,
            OffcanvasSize.Small => "bb-offcanvas-sm",
            OffcanvasSize.Large => "bb-offcanvas-lg",
            _ => null
        };

    public string Tooltip() => "b-tooltip";

    public string TooltipAlwaysActive() => "b-tooltip-active";

    public string TooltipColor(TooltipColor color) => ToTooltipColor(color);

    public string TooltipFade() => "b-tooltip-fade";

    public string TooltipInline() => "b-tooltip-inline";

    public string TooltipMultiline() => "b-tooltip-multiline";

    public string TooltipPlacement(TooltipPlacement tooltipPlacement) => $"{Tooltip()}-{ToTooltipPlacement(tooltipPlacement)}";

    public string ToPaginationSize(PaginationSize size) =>
        size switch
        {
            Enums.PaginationSize.Small => "sm",
            Enums.PaginationSize.Large => "lg",
            _ => null
        };

    public string ToPlaceholderAnimation(PlaceholderAnimation animation) =>
        animation switch
        {
            Enums.PlaceholderAnimation.Glow => "glow",
            Enums.PlaceholderAnimation.Wave => "wave",
            _ => null
        };

    public string ToPlaceholderColor(PlaceholderColor color) =>
        color switch
        {
            Enums.Color.PlaceholderColor.Primary => "primary",
            Enums.Color.PlaceholderColor.Secondary => "secondary",
            Enums.Color.PlaceholderColor.Success => "success",
            Enums.Color.PlaceholderColor.Danger => "danger",
            Enums.Color.PlaceholderColor.Warning => "warning",
            Enums.Color.PlaceholderColor.Info => "info",
            Enums.Color.PlaceholderColor.Light => "light",
            Enums.Color.PlaceholderColor.Dark => "dark",
            _ => null
        };

    public string ToPlaceholderSize(PlaceholderSize size) =>
        size switch
        {
            Enums.PlaceholderSize.ExtraSmall => "xs",
            Enums.PlaceholderSize.Small => "sm",
            Enums.PlaceholderSize.Large => "lg",
            _ => null
        };

    public string ToPlaceholderWidth(PlaceholderWidth width) =>
        width switch
        {
            Enums.PlaceholderWidth.Col1 => "col-1",
            Enums.PlaceholderWidth.Col2 => "col-2",
            Enums.PlaceholderWidth.Col3 => "col-3",
            Enums.PlaceholderWidth.Col4 => "col-4",
            Enums.PlaceholderWidth.Col5 => "col-5",
            Enums.PlaceholderWidth.Col6 => "col-6",
            Enums.PlaceholderWidth.Col7 => "col-7",
            Enums.PlaceholderWidth.Col8 => "col-8",
            Enums.PlaceholderWidth.Col9 => "col-9",
            Enums.PlaceholderWidth.Col10 => "col-10",
            Enums.PlaceholderWidth.Col11 => "col-11",
            Enums.PlaceholderWidth.Col12 => "col-12",
            _ => null
        };

    public string ToPlacement(Placement placement) =>
        placement switch
        {
            Placement.Start => "start",
            Placement.End => "end",
            Placement.Top => "top",
            _ => "bottom"
        };

    public string ToPosition(Position position) =>
        position switch
        {
            Enums.Position.Static => PositionAbsolute(),
            Enums.Position.Relative => PositionRelative(),
            Enums.Position.Absolute => PositionAbsolute(),
            Enums.Position.Fixed => PositionFixed(),
            Enums.Position.Sticky => PositionSticky(),
            _ => ""
        };

    public string ToProgressColor(ProgressColor color) =>
        color switch
        {
            ProgressColor.Primary => "primary",
            ProgressColor.Secondary => "secondary",
            ProgressColor.Success => "success",
            ProgressColor.Danger => "danger",
            ProgressColor.Warning => "warning",
            ProgressColor.Info => "info",
            ProgressColor.Dark => "dark",
            _ => null
        };

    public string ToScreenreader(Screenreader screenreader) =>
        screenreader switch
        {
            Screenreader.Only => "sr-only",
            Screenreader.OnlyFocusable => "sr-only-focusable",
            _ => null
        };

    public string ToSize(Size size) =>
        size switch
        {
            Size.ExtraSmall => "xs",
            Size.Small => "sm",
            Size.Medium => "md",
            Size.Large => "lg",
            Size.ExtraLarge => "xl",
            _ => null
        };

    public string ToTabColor(TabColor color) =>
        color switch
        {
            TabColor.Primary => "bg-primary text-white",
            TabColor.Secondary => "bg-secondary text-white",
            TabColor.Success => "bg-success text-white",
            TabColor.Danger => "bg-danger text-white",
            TabColor.Warning => "bg-warning text-dark",
            TabColor.Info => "bg-info text-dark",
            TabColor.Light => "bg-light text-dark",
            TabColor.Dark => "bg-dark text-white",
            _ => null
        };

    public string ToTextAlignment(Alignment alignment) =>
        alignment switch
        {
            Alignment.Start or Alignment.None => "text-start",
            Alignment.Center => "text-center",
            Alignment.End => "text-end",
            _ => ""
        };

    public string ToTextColor(TextColor color) =>
        color switch
        {
            Enums.Color.TextColor.Primary => "primary",
            Enums.Color.TextColor.Secondary => "secondary",
            Enums.Color.TextColor.Success => "success",
            Enums.Color.TextColor.Danger => "danger",
            Enums.Color.TextColor.Warning => "warning",
            Enums.Color.TextColor.Info => "info",
            Enums.Color.TextColor.Light => "light",
            Enums.Color.TextColor.Dark => "dark",
            Enums.Color.TextColor.Body => "body",
            Enums.Color.TextColor.Muted => "muted",
            Enums.Color.TextColor.White => "white",
            _ => null
        };

    public string ToToastBackgroundColor(ToastType toastType) =>
        toastType switch
        {
            ToastType.Primary => "primary",
            ToastType.Secondary => "secondary",
            ToastType.Success => "success",
            ToastType.Danger => "danger",
            ToastType.Warning => "warning",
            ToastType.Info => "info",
            ToastType.Light => "light",
            ToastType.Dark => "dark",
            _ => null
        };

    public string ToToastsPlacement(ToastsPlacement toastsPlacement) =>
        toastsPlacement switch
        {
            ToastsPlacement.TopLeft => "top-0 start-0",
            ToastsPlacement.TopCenter => "top-0 start-50 translate-middle-x",
            ToastsPlacement.TopRight => "top-0 end-0",
            ToastsPlacement.MiddleLeft => "top-50 start-0 translate-middle-y",
            ToastsPlacement.MiddleCenter => "top-50 start-50 translate-middle",
            ToastsPlacement.MiddleRight => "top-50 end-0 translate-middle-y",
            ToastsPlacement.BottomLeft => "bottom-0 start-0",
            ToastsPlacement.BottomCenter => "bottom-0 start-50 translate-middle-x",
            ToastsPlacement.BottomRight => "bottom-0 end-0",
            _ => "top-0 end-0" // default: Top right
        };

    public string ToToastTextColor(ToastType toastType) =>
        toastType switch
        {
            ToastType.Primary
                or ToastType.Secondary
                or ToastType.Success
                or ToastType.Danger
                or ToastType.Dark => "white",
            ToastType.Warning
                or ToastType.Info
                or ToastType.Light => "dark",
            _ => null
        };

    public string ToTooltipColor(TooltipColor color) =>
        color switch
        {
            Enums.Color.TooltipColor.Primary => "bb-tooltip-primary",
            Enums.Color.TooltipColor.Secondary => "bb-tooltip-tooltip-secondary",
            Enums.Color.TooltipColor.Success => "bb-tooltip-success",
            Enums.Color.TooltipColor.Danger => "bb-tooltip-danger",
            Enums.Color.TooltipColor.Warning => "bb-tooltip-warning",
            Enums.Color.TooltipColor.Info => "bb-tooltip-info",
            Enums.Color.TooltipColor.Light => "bb-tooltip-light",
            Enums.Color.TooltipColor.Dark => "bb-tooltip-dark",
            _ => null
        };

    public string ToTooltipPlacement(TooltipPlacement tooltipPlacement) =>
        tooltipPlacement switch
        {
            Enums.TooltipPlacement.Bottom => "bottom",
            Enums.TooltipPlacement.Left => "left",
            Enums.TooltipPlacement.Right => "right",
            _ => "top"
        };

    #endregion

    #region Properties, Indexers

    public string Nav => "nav";
    public string NavPills => $"{Nav}-pills";
    public string NavTabs => $"{Nav}-tabs";

    #endregion
}
