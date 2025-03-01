﻿namespace Plotly.NET.LayoutObjects

open Plotly.NET
open DynamicObj
open System
open System.Runtime.InteropServices

/// <summary>Radial axes can be used as a scale for the radial coordinates in polar plots.</summary>
type RadialAxis() =
    inherit DynamicObj()

    /// <summary>
    /// Initialize an AngularAxis object that can be used as a angular scale for polar coordinates.
    /// </summary>
    /// <param name="Visible">A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false</param>
    /// <param name="AxisType">Sets the angular axis type. If "linear", set `thetaunit` to determine the unit in which axis value are shown. If "category, use `period` to set the number of integer coordinates around polar axis.</param>
    /// <param name="AutoTypeNumbers">Using "strict" a numeric string in trace data is not converted to a number. Using "convert types" a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers.</param>
    /// <param name="AutoRange">Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to "false".</param>
    /// <param name="RangeMode">If "tozero"`, the range extends to 0, regardless of the input data If "nonnegative", the range is non-negative, regardless of the input data. If "normal", the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).</param>
    /// <param name="Range">Sets the range of this axis. If the axis `type` is "log", then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is "date", it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is "category", it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
    /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
    /// <param name="Angle">Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.</param>
    /// <param name="Side">Determines on which side of radial axis line the tick and tick labels appear.</param>
    /// <param name="Title">Sets the title of the Radial Axis.</param>
    /// <param name="HoverFormat">Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="UIRevision">Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar&lt;N&gt;.uirevision`.</param>
    /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.</param>
    /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
    /// <param name="LineColor">Sets the axis line color.</param>
    /// <param name="LineWidth">Sets the width (in px) of the axis line.</param>
    /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
    /// <param name="GridColor">Sets the color of the grid lines.</param>
    /// <param name="GridDash">Sets the dash style of lines. Set to a dash type string ("solid", "dot", "dash", "longdash", "dashdot", or "longdashdot") or a dash length list in px (eg "5px,10px,2px,2px").</param>
    /// <param name="GridWidth">Sets the width (in px) of the grid lines.</param>
    /// <param name="TickMode">Sets the tick mode for this axis. If "auto", the number of ticks is set via `nticks`. If "linear", the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` ("linear" is the default value if `tick0` and `dtick` are provided). If "array", the placement of the ticks is set via `TickVals` and the tick text is `TickText`. ("array" is the default value if `TickVals` is provided).</param>
    /// <param name="NTicks">Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to "auto".</param>
    /// <param name="Tick0">Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is "log", then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`="L&lt;f&gt;" (see `dtick` for more info). If the axis `type` is "date", it should be a date string, like date data. If the axis `type` is "category", it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="DTick">Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to "log" and "date" axes. If the axis `type` is "log", then ticks are set every 10^(n"dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. "log" has several special values; "L&lt;f&gt;", where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = "L0.5" will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use "D1" (all digits) or "D2" (only 2 and 5). `tick0` is ignored for "D1" and "D2". If the axis `type` is "date", then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. "date" also has special values "M&lt;n&gt;" gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to "2000-01-15" and `dtick` to "M3". To set ticks every 4 years, set `dtick` to "M48"</param>
    /// <param name="TickVals">Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to "array". Used with `TickText`.</param>
    /// <param name="TickText">Sets the text displayed at the ticks position via `TickVals`. Only has an effect if `tickmode` is set to "array". Used with `TickVals`.</param>
    /// <param name="Ticks">Determines whether ticks are drawn or not. If "", this axis' ticks are not drawn. If "outside" ("inside"), this axis' are drawn outside (inside) the axis lines.</param>
    /// <param name="TickLen">Sets the tick length (in px).</param>
    /// <param name="TickWidth">Sets the tick width (in px).</param>
    /// <param name="TickColor">Sets the tick color.</param>
    /// <param name="ShowTickLabels">Determines whether or not the tick labels are drawn.</param>
    /// <param name="ShowTickPrefix">If "all", all tick labels are displayed with a prefix. If "first", only the first tick is displayed with a prefix. If "last", only the last tick is displayed with a suffix. If "none", tick prefixes are hidden.</param>
    /// <param name="TickPrefix">Sets a tick label prefix.</param>
    /// <param name="ShowTickSuffix">Same as `showtickprefix` but for tick suffixes.</param>
    /// <param name="TickSuffix">Sets a tick label suffix.</param>
    /// <param name="ShowExponent">If "all", all exponents are shown besides their significands. If "first", only the exponent of the first tick is shown. If "last", only the exponent of the last tick is shown. If "none", no exponents appear.</param>
    /// <param name="ExponentFormat">Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If "none", it appears as 1,000,000,000. If "e", 1e+9. If "E", 1E+9. If "power", 1x10^9 (with 9 in a super script). If "SI", 1G. If "B", 1B.</param>
    /// <param name="MinExponent">Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `TickFormat` is "SI" or "B".</param>
    /// <param name="SeparateThousands">If "true", even 4-digit integers are separated</param>
    /// <param name="TickFont">Sets the tick font.</param>
    /// <param name="TickAngle">Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.</param>
    /// <param name="TickFormat">Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="TickFormatStops">Set rules for customizing TickFormat on different zoom levels</param>
    /// <param name="LabelAlias">Replacement text for specific tick or hover labels. For example using {US: 'USA', CA: 'Canada'} changes US to USA and CA to Canada. The labels we would have shown must match the keys exactly, after adding any tickprefix or ticksuffix. labelalias can be used with any axis type, and both keys (if needed) and values (if desired) can include html-like tags or MathJax.</param>
    /// <param name="Layer">Sets the layer on which this axis is displayed. If "above traces", this axis is displayed above all the subplot's traces If "below traces", this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to "false" to show markers and/or text nodes above this axis.</param>
    /// <param name="TickLabelStep">Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` "log" or "multicategory", or when `tickmode` is "array".</param>
    /// <param name="Calendar">Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`</param>
    static member init
        (
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?AxisType: StyleParam.AxisType,
            [<Optional; DefaultParameterValue(null)>] ?AutoTypeNumbers: StyleParam.AutoTypeNumbers,
            [<Optional; DefaultParameterValue(null)>] ?AutoRange: StyleParam.AutoRange,
            [<Optional; DefaultParameterValue(null)>] ?RangeMode: StyleParam.RangeMode,
            [<Optional; DefaultParameterValue(null)>] ?Range: StyleParam.Range,
            [<Optional; DefaultParameterValue(null)>] ?CategoryOrder: StyleParam.CategoryOrder,
            [<Optional; DefaultParameterValue(null)>] ?CategoryArray: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Angle: float,
            [<Optional; DefaultParameterValue(null)>] ?Side: StyleParam.Direction,
            [<Optional; DefaultParameterValue(null)>] ?Title: Title,
            [<Optional; DefaultParameterValue(null)>] ?HoverFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?UIRevision: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?Color: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowLine: bool,
            [<Optional; DefaultParameterValue(null)>] ?LineColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?LineWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?ShowGrid: bool,
            [<Optional; DefaultParameterValue(null)>] ?GridColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?GridDash: StyleParam.DrawingStyle,
            [<Optional; DefaultParameterValue(null)>] ?GridWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickMode: StyleParam.TickMode,
            [<Optional; DefaultParameterValue(null)>] ?NTicks: int,
            [<Optional; DefaultParameterValue(null)>] ?Tick0: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?DTick: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?TickVals: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?TickText: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Ticks: StyleParam.TickOptions,
            [<Optional; DefaultParameterValue(null)>] ?TickLen: int,
            [<Optional; DefaultParameterValue(null)>] ?TickWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickLabels: bool,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickPrefix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickPrefix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickSuffix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickSuffix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowExponent: StyleParam.ShowExponent,
            [<Optional; DefaultParameterValue(null)>] ?ExponentFormat: StyleParam.ExponentFormat,
            [<Optional; DefaultParameterValue(null)>] ?MinExponent: float,
            [<Optional; DefaultParameterValue(null)>] ?SeparateThousands: bool,
            [<Optional; DefaultParameterValue(null)>] ?TickFont: Font,
            [<Optional; DefaultParameterValue(null)>] ?TickAngle: int,
            [<Optional; DefaultParameterValue(null)>] ?TickFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?TickFormatStops: seq<TickFormatStop>,
            [<Optional; DefaultParameterValue(null)>] ?LabelAlias: DynamicObj,
            [<Optional; DefaultParameterValue(null)>] ?Layer: StyleParam.Layer,
            [<Optional; DefaultParameterValue(null)>] ?TickLabelStep: int,
            [<Optional; DefaultParameterValue(null)>] ?Calendar: StyleParam.Calendar
        ) =
        RadialAxis()
        |> RadialAxis.style (
            ?Visible = Visible,
            ?AxisType = AxisType,
            ?AutoTypeNumbers = AutoTypeNumbers,
            ?AutoRange = AutoRange,
            ?RangeMode = RangeMode,
            ?Range = Range,
            ?CategoryOrder = CategoryOrder,
            ?CategoryArray = CategoryArray,
            ?Angle = Angle,
            ?Side = Side,
            ?Title = Title,
            ?HoverFormat = HoverFormat,
            ?UIRevision = UIRevision,
            ?Color = Color,
            ?ShowLine = ShowLine,
            ?LineColor = LineColor,
            ?LineWidth = LineWidth,
            ?ShowGrid = ShowGrid,
            ?GridColor = GridColor,
            ?GridDash = GridDash,
            ?GridWidth = GridWidth,
            ?TickMode = TickMode,
            ?NTicks = NTicks,
            ?Tick0 = Tick0,
            ?DTick = DTick,
            ?TickVals = TickVals,
            ?TickText = TickText,
            ?Ticks = Ticks,
            ?TickLen = TickLen,
            ?TickWidth = TickWidth,
            ?TickColor = TickColor,
            ?ShowTickLabels = ShowTickLabels,
            ?ShowTickPrefix = ShowTickPrefix,
            ?TickPrefix = TickPrefix,
            ?ShowTickSuffix = ShowTickSuffix,
            ?TickSuffix = TickSuffix,
            ?ShowExponent = ShowExponent,
            ?ExponentFormat = ExponentFormat,
            ?MinExponent = MinExponent,
            ?SeparateThousands = SeparateThousands,
            ?TickFont = TickFont,
            ?TickAngle = TickAngle,
            ?TickFormat = TickFormat,
            ?TickFormatStops = TickFormatStops,
            ?LabelAlias = LabelAlias,
            ?Layer = Layer,
            ?TickLabelStep = TickLabelStep,
            ?Calendar = Calendar
        )

    /// <summary>
    /// Creates a function that applies the given style parameters to a RadialAxis object
    /// </summary>
    /// <param name="Visible">A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false</param>
    /// <param name="AxisType">Sets the angular axis type. If "linear", set `thetaunit` to determine the unit in which axis value are shown. If "category, use `period` to set the number of integer coordinates around polar axis.</param>
    /// <param name="AutoTypeNumbers">Using "strict" a numeric string in trace data is not converted to a number. Using "convert types" a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers.</param>
    /// <param name="AutoRange">Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to "false".</param>
    /// <param name="RangeMode">If "tozero"`, the range extends to 0, regardless of the input data If "nonnegative", the range is non-negative, regardless of the input data. If "normal", the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).</param>
    /// <param name="Range">Sets the range of this axis. If the axis `type` is "log", then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is "date", it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is "category", it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
    /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
    /// <param name="Angle">Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.</param>
    /// <param name="Side">Determines on which side of radial axis line the tick and tick labels appear.</param>
    /// <param name="Title">Sets the title of the Radial Axis.</param>
    /// <param name="HoverFormat">Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="UIRevision">Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar&lt;N&gt;.uirevision`.</param>
    /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.</param>
    /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
    /// <param name="LineColor">Sets the axis line color.</param>
    /// <param name="LineWidth">Sets the width (in px) of the axis line.</param>
    /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
    /// <param name="GridColor">Sets the color of the grid lines.</param>
    /// <param name="GridDash">Sets the dash style of lines. Set to a dash type string ("solid", "dot", "dash", "longdash", "dashdot", or "longdashdot") or a dash length list in px (eg "5px,10px,2px,2px").</param>
    /// <param name="GridWidth">Sets the width (in px) of the grid lines.</param>
    /// <param name="TickMode">Sets the tick mode for this axis. If "auto", the number of ticks is set via `nticks`. If "linear", the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` ("linear" is the default value if `tick0` and `dtick` are provided). If "array", the placement of the ticks is set via `TickVals` and the tick text is `TickText`. ("array" is the default value if `TickVals` is provided).</param>
    /// <param name="NTicks">Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to "auto".</param>
    /// <param name="Tick0">Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is "log", then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`="L&lt;f&gt;" (see `dtick` for more info). If the axis `type` is "date", it should be a date string, like date data. If the axis `type` is "category", it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="DTick">Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to "log" and "date" axes. If the axis `type` is "log", then ticks are set every 10^(n"dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. "log" has several special values; "L&lt;f&gt;", where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = "L0.5" will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use "D1" (all digits) or "D2" (only 2 and 5). `tick0` is ignored for "D1" and "D2". If the axis `type` is "date", then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. "date" also has special values "M&lt;n&gt;" gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to "2000-01-15" and `dtick` to "M3". To set ticks every 4 years, set `dtick` to "M48"</param>
    /// <param name="TickVals">Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to "array". Used with `TickText`.</param>
    /// <param name="TickText">Sets the text displayed at the ticks position via `TickVals`. Only has an effect if `tickmode` is set to "array". Used with `TickVals`.</param>
    /// <param name="Ticks">Determines whether ticks are drawn or not. If "", this axis' ticks are not drawn. If "outside" ("inside"), this axis' are drawn outside (inside) the axis lines.</param>
    /// <param name="TickLen">Sets the tick length (in px).</param>
    /// <param name="TickWidth">Sets the tick width (in px).</param>
    /// <param name="TickColor">Sets the tick color.</param>
    /// <param name="ShowTickLabels">Determines whether or not the tick labels are drawn.</param>
    /// <param name="ShowTickPrefix">If "all", all tick labels are displayed with a prefix. If "first", only the first tick is displayed with a prefix. If "last", only the last tick is displayed with a suffix. If "none", tick prefixes are hidden.</param>
    /// <param name="TickPrefix">Sets a tick label prefix.</param>
    /// <param name="ShowTickSuffix">Same as `showtickprefix` but for tick suffixes.</param>
    /// <param name="TickSuffix">Sets a tick label suffix.</param>
    /// <param name="ShowExponent">If "all", all exponents are shown besides their significands. If "first", only the exponent of the first tick is shown. If "last", only the exponent of the last tick is shown. If "none", no exponents appear.</param>
    /// <param name="ExponentFormat">Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If "none", it appears as 1,000,000,000. If "e", 1e+9. If "E", 1E+9. If "power", 1x10^9 (with 9 in a super script). If "SI", 1G. If "B", 1B.</param>
    /// <param name="MinExponent">Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `TickFormat` is "SI" or "B".</param>
    /// <param name="SeparateThousands">If "true", even 4-digit integers are separated</param>
    /// <param name="TickFont">Sets the tick font.</param>
    /// <param name="TickAngle">Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.</param>
    /// <param name="TickFormat">Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="TickFormatStops">Set rules for customizing TickFormat on different zoom levels</param>
    /// <param name="LabelAlias">Replacement text for specific tick or hover labels. For example using {US: 'USA', CA: 'Canada'} changes US to USA and CA to Canada. The labels we would have shown must match the keys exactly, after adding any tickprefix or ticksuffix. labelalias can be used with any axis type, and both keys (if needed) and values (if desired) can include html-like tags or MathJax.</param>
    /// <param name="Layer">Sets the layer on which this axis is displayed. If "above traces", this axis is displayed above all the subplot's traces If "below traces", this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to "false" to show markers and/or text nodes above this axis.</param>
    /// <param name="TickLabelStep">Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` "log" or "multicategory", or when `tickmode` is "array".</param>
    /// <param name="Calendar">Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`</param>
    static member style
        (
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?AxisType: StyleParam.AxisType,
            [<Optional; DefaultParameterValue(null)>] ?AutoTypeNumbers: StyleParam.AutoTypeNumbers,
            [<Optional; DefaultParameterValue(null)>] ?AutoRange: StyleParam.AutoRange,
            [<Optional; DefaultParameterValue(null)>] ?RangeMode: StyleParam.RangeMode,
            [<Optional; DefaultParameterValue(null)>] ?Range: StyleParam.Range,
            [<Optional; DefaultParameterValue(null)>] ?CategoryOrder: StyleParam.CategoryOrder,
            [<Optional; DefaultParameterValue(null)>] ?CategoryArray: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Angle: float,
            [<Optional; DefaultParameterValue(null)>] ?Side: StyleParam.Direction,
            [<Optional; DefaultParameterValue(null)>] ?Title: Title,
            [<Optional; DefaultParameterValue(null)>] ?HoverFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?UIRevision: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?Color: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowLine: bool,
            [<Optional; DefaultParameterValue(null)>] ?LineColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?LineWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?ShowGrid: bool,
            [<Optional; DefaultParameterValue(null)>] ?GridColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?GridDash: StyleParam.DrawingStyle,
            [<Optional; DefaultParameterValue(null)>] ?GridWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickMode: StyleParam.TickMode,
            [<Optional; DefaultParameterValue(null)>] ?NTicks: int,
            [<Optional; DefaultParameterValue(null)>] ?Tick0: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?DTick: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?TickVals: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?TickText: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Ticks: StyleParam.TickOptions,
            [<Optional; DefaultParameterValue(null)>] ?TickLen: int,
            [<Optional; DefaultParameterValue(null)>] ?TickWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickLabels: bool,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickPrefix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickPrefix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickSuffix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickSuffix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowExponent: StyleParam.ShowExponent,
            [<Optional; DefaultParameterValue(null)>] ?ExponentFormat: StyleParam.ExponentFormat,
            [<Optional; DefaultParameterValue(null)>] ?MinExponent: float,
            [<Optional; DefaultParameterValue(null)>] ?SeparateThousands: bool,
            [<Optional; DefaultParameterValue(null)>] ?TickFont: Font,
            [<Optional; DefaultParameterValue(null)>] ?TickAngle: int,
            [<Optional; DefaultParameterValue(null)>] ?TickFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?TickFormatStops: seq<TickFormatStop>,
            [<Optional; DefaultParameterValue(null)>] ?LabelAlias: DynamicObj,
            [<Optional; DefaultParameterValue(null)>] ?Layer: StyleParam.Layer,
            [<Optional; DefaultParameterValue(null)>] ?TickLabelStep: int,
            [<Optional; DefaultParameterValue(null)>] ?Calendar: StyleParam.Calendar
        ) =
        fun (radialAxis: RadialAxis) ->

            Visible |> DynObj.setValueOpt radialAxis "visible"
            AxisType |> DynObj.setValueOptBy radialAxis "type" StyleParam.AxisType.convert
            AutoTypeNumbers |> DynObj.setValueOptBy radialAxis "autotypenumbers" StyleParam.AutoTypeNumbers.convert
            AutoRange |> DynObj.setValueOptBy radialAxis "autorange" StyleParam.AutoRange.convert
            RangeMode |> DynObj.setValueOptBy radialAxis "rangemode" StyleParam.RangeMode.convert
            Range |> DynObj.setValueOptBy radialAxis "range" StyleParam.Range.convert
            CategoryOrder |> DynObj.setValueOptBy radialAxis "categoryorder" StyleParam.CategoryOrder.convert
            CategoryArray |> DynObj.setValueOpt radialAxis "categoryarray"
            Angle |> DynObj.setValueOpt radialAxis "angle"
            Side |> DynObj.setValueOptBy radialAxis "side" StyleParam.Direction.convert
            Title |> DynObj.setValueOpt radialAxis "title"
            HoverFormat |> DynObj.setValueOpt radialAxis "hoverformat"
            UIRevision |> DynObj.setValueOpt radialAxis "uirevision"
            Color |> DynObj.setValueOpt radialAxis "color"
            ShowLine |> DynObj.setValueOpt radialAxis "showline"
            LineColor |> DynObj.setValueOpt radialAxis "linecolor"
            LineWidth |> DynObj.setValueOpt radialAxis "linewidth"
            ShowGrid |> DynObj.setValueOpt radialAxis "showgrid"
            GridColor |> DynObj.setValueOpt radialAxis "gridcolor"
            GridDash |> DynObj.setValueOptBy radialAxis "griddash" StyleParam.DrawingStyle.convert
            GridWidth |> DynObj.setValueOpt radialAxis "gridwidth"
            TickMode |> DynObj.setValueOptBy radialAxis "tickmode" StyleParam.TickMode.convert
            NTicks |> DynObj.setValueOpt radialAxis "nticks"
            Tick0 |> DynObj.setValueOpt radialAxis "tick0"
            DTick |> DynObj.setValueOpt radialAxis "dtick"
            TickVals |> DynObj.setValueOpt radialAxis "tickvals"
            TickText |> DynObj.setValueOpt radialAxis "ticktext"
            Ticks |> DynObj.setValueOptBy radialAxis "ticks" StyleParam.TickOptions.convert
            TickLen |> DynObj.setValueOpt radialAxis "ticklen"
            TickWidth |> DynObj.setValueOpt radialAxis "tickwidth"
            TickColor |> DynObj.setValueOpt radialAxis "tickcolor"
            ShowTickLabels |> DynObj.setValueOpt radialAxis "showticklabels"
            ShowTickPrefix |> DynObj.setValueOptBy radialAxis "showtickprefix" StyleParam.ShowTickOption.convert
            TickPrefix |> DynObj.setValueOpt radialAxis "tickprefix"
            ShowTickSuffix |> DynObj.setValueOptBy radialAxis "showticksuffix" StyleParam.ShowTickOption.convert
            TickSuffix |> DynObj.setValueOpt radialAxis "ticksuffix"
            ShowExponent |> DynObj.setValueOptBy radialAxis "showexponent" StyleParam.ShowExponent.convert
            ExponentFormat |> DynObj.setValueOptBy radialAxis "exponentformat" StyleParam.ExponentFormat.convert
            MinExponent |> DynObj.setValueOpt radialAxis "minexponent"
            SeparateThousands |> DynObj.setValueOpt radialAxis "separatethousands"
            TickFont |> DynObj.setValueOpt radialAxis "tickfont"
            TickAngle |> DynObj.setValueOpt radialAxis "tickangle"
            TickFormat |> DynObj.setValueOpt radialAxis "tickformat"
            TickFormatStops |> DynObj.setValueOpt radialAxis "tickformatstops"
            LabelAlias |> DynObj.setValueOpt radialAxis "labelalias"
            Layer |> DynObj.setValueOptBy radialAxis "layer" StyleParam.Layer.convert
            TickLabelStep |> DynObj.setValueOpt radialAxis "ticklabelstep"
            Calendar |> DynObj.setValueOptBy radialAxis "calendar" StyleParam.Calendar.convert

            radialAxis
