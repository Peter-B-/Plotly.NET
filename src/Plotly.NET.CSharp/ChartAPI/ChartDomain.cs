﻿using Microsoft.FSharp.Core;
using Plotly.NET;
using Plotly.NET.LayoutObjects;
using Plotly.NET.TraceObjects;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Plotly.NET.CSharp
{
    public static partial class Chart
    {
        /// <summary>
        /// Creates a pie chart.
        ///
        /// A pie chart (or a circle chart) is a circular statistical graphic, which is divided into slices to illustrate numerical proportion.
        /// In a pie chart, the arc length of each slice (and consequently its central angle and area), is proportional to the quantity it represents.
        /// </summary>
        /// <param name="values">Sets the values of the sectors</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover</param>
        /// <param name="ShowLegend">Determines whether or not an item corresponding to this trace is shown in the legend.</param>
        /// <param name="Opacity">Sets the opactity of the trace</param>
        /// <param name="MultiOpacity">Sets the opactity of individual datum markers</param>
        /// <param name="Labels">Sets the sector labels. If `labels` entries are duplicated, the associated `values` are summed.</param>
        /// <param name="Pull">Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.</param>
        /// <param name="MultiPull">Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.</param>
        /// <param name="Text">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="MultiText">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="TextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="MultiTextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="SectionColors">Sets the colors associated with each section.</param>
        /// <param name="SectionOutlineColor">Sets the color of the section outline.</param>
        /// <param name="SectionOutlineWidth">Sets the width of the section outline.</param>
        /// <param name="SectionOutlineMultiWidth">Sets the width of each individual section outline.</param>
        /// <param name="SectionOutline">Sets the section outline (use this for more finegrained control than the other section outline-associated arguments).</param>
        /// <param name="Marker">Sets the marker of this trace.</param>
        /// <param name="TextInfo">Determines which trace information appear on the graph.</param>
        /// <param name="Direction">Specifies the direction at which succeeding sectors follow one another.</param>
        /// <param name="Hole">Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.</param>
        /// <param name="Rotation">Instead of the first slice starting at 12 o'clock, rotate to some other angle.</param>
        /// <param name="Sort">Determines whether or not the sectors are reordered from largest to smallest.</param>
        /// <param name="UseDefaults">If set to false, ignore the global default settings set in `Defaults`</param>
        public static GenericChart.GenericChart Pie<ValuesType, LabelsType, TextType>(
            IEnumerable<ValuesType> values,
            Optional<string> Name = default,
            Optional<bool> ShowLegend = default,
            Optional<double> Opacity = default,
            Optional<IEnumerable<double>> MultiOpacity = default,
            Optional<IEnumerable<LabelsType>> Labels = default,
            Optional<double> Pull = default,
            Optional<IEnumerable<double>> MultiPull = default,
            Optional<TextType> Text = default,
            Optional<IEnumerable<TextType>> MultiText = default,
            Optional<StyleParam.TextPosition> TextPosition = default,
            Optional<IEnumerable<StyleParam.TextPosition>> MultiTextPosition = default,
            Optional<IEnumerable<Color>> SectionColors = default,
            Optional<Color> SectionOutlineColor = default,
            Optional<double> SectionOutlineWidth = default,
            Optional<IEnumerable<double>> SectionOutlineMultiWidth = default,
            Optional<Line> SectionOutline = default,
            Optional<Marker> Marker = default,
            Optional<StyleParam.TextInfo> TextInfo = default,
            Optional<StyleParam.Direction> Direction = default,
            Optional<double> Hole = default,
            Optional<double> Rotation = default,
            Optional<bool> Sort = default,
            Optional<bool> UseDefaults = default
        )
            where ValuesType : IConvertible
            where LabelsType : IConvertible
            where TextType : IConvertible
            =>
                Plotly.NET.ChartDomain.Chart.Pie<ValuesType, LabelsType, TextType>(
                    values: values,
                    Name: Name.ToOption(),
                    ShowLegend: ShowLegend.ToOption(),
                    Opacity: Opacity.ToOption(),
                    MultiOpacity: MultiOpacity.ToOption(),
                    Labels: Labels.ToOption(),
                    Pull: Pull.ToOption(),
                    MultiPull: MultiPull.ToOption(),
                    Text: Text.ToOption(),
                    MultiText: MultiText.ToOption(),
                    TextPosition: TextPosition.ToOption(),
                    MultiTextPosition: MultiTextPosition.ToOption(),
                    SectionColors: SectionColors.ToOption(),
                    SectionOutlineColor: SectionOutlineColor.ToOption(),
                    SectionOutlineWidth: SectionOutlineWidth.ToOption(),
                    SectionOutlineMultiWidth: SectionOutlineMultiWidth.ToOption(),
                    SectionOutline: SectionOutline.ToOption(),
                    Marker: Marker.ToOption(),
                    TextInfo: TextInfo.ToOption(),
                    Direction: Direction.ToOption(),
                    Hole: Hole.ToOption(),
                    Rotation: Rotation.ToOption(),
                    Sort: Sort.ToOption(),
                    UseDefaults: UseDefaults.ToOption()
                );

        /// <summary>
        /// Creates a doughnut chart.
        ///
        /// A doughnut chart is a variation of the pie chart that has a fraction cut fron the center of the slices.
        /// </summary>
        /// <param name="values">Sets the values of the sectors</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover</param>
        /// <param name="Hole">Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.</param>
        /// <param name="ShowLegend">Determines whether or not an item corresponding to this trace is shown in the legend.</param>
        /// <param name="Opacity">Sets the opactity of the trace</param>
        /// <param name="MultiOpacity">Sets the opactity of individual datum markers</param>
        /// <param name="Labels">Sets the sector labels. If `labels` entries are duplicated, the associated `values` are summed.</param>
        /// <param name="Pull">Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.</param>
        /// <param name="MultiPull">Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.</param>
        /// <param name="Text">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="MultiText">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="TextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="MultiTextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="SectionColors">Sets the colors associated with each section.</param>
        /// <param name="SectionOutlineColor">Sets the color of the section outline.</param>
        /// <param name="SectionOutlineWidth">Sets the width of the section outline.</param>
        /// <param name="SectionOutlineMultiWidth">Sets the width of each individual section outline.</param>
        /// <param name="SectionOutline">Sets the section outline (use this for more finegrained control than the other section outline-associated arguments).</param>
        /// <param name="Marker">Sets the marker of this trace.</param>
        /// <param name="TextInfo">Determines which trace information appear on the graph.</param>
        /// <param name="Direction">Specifies the direction at which succeeding sectors follow one another.</param>
        /// <param name="Rotation">Instead of the first slice starting at 12 o'clock, rotate to some other angle.</param>
        /// <param name="Sort">Determines whether or not the sectors are reordered from largest to smallest.</param>
        /// <param name="UseDefaults">If set to false, ignore the global default settings set in `Defaults`</param>
        public static GenericChart.GenericChart Doughnut<ValuesType, LabelsType, TextType>(
            IEnumerable<ValuesType> values,
            Optional<string> Name = default,
            Optional<bool> ShowLegend = default,
            Optional<double> Opacity = default,
            Optional<IEnumerable<double>> MultiOpacity = default,
            Optional<IEnumerable<LabelsType>> Labels = default,
            Optional<double> Pull = default,
            Optional<IEnumerable<double>> MultiPull = default,
            Optional<TextType> Text = default,
            Optional<IEnumerable<TextType>> MultiText = default,
            Optional<StyleParam.TextPosition> TextPosition = default,
            Optional<IEnumerable<StyleParam.TextPosition>> MultiTextPosition = default,
            Optional<IEnumerable<Color>> SectionColors = default,
            Optional<Color> SectionOutlineColor = default,
            Optional<double> SectionOutlineWidth = default,
            Optional<IEnumerable<double>> SectionOutlineMultiWidth = default,
            Optional<Line> SectionOutline = default,
            Optional<Marker> Marker = default,
            Optional<StyleParam.TextInfo> TextInfo = default,
            Optional<StyleParam.Direction> Direction = default,
            Optional<double> Hole = default,
            Optional<double> Rotation = default,
            Optional<bool> Sort = default,
            Optional<bool> UseDefaults = default
        )
            where ValuesType : IConvertible
            where LabelsType : IConvertible
            where TextType : IConvertible
            =>
                Plotly.NET.ChartDomain.Chart.Doughnut<ValuesType, LabelsType, TextType>(
                    values: values,
                    Name: Name.ToOption(),
                    ShowLegend: ShowLegend.ToOption(),
                    Opacity: Opacity.ToOption(),
                    MultiOpacity: MultiOpacity.ToOption(),
                    Labels: Labels.ToOption(),
                    Pull: Pull.ToOption(),
                    MultiPull: MultiPull.ToOption(),
                    Text: Text.ToOption(),
                    MultiText: MultiText.ToOption(),
                    TextPosition: TextPosition.ToOption(),
                    MultiTextPosition: MultiTextPosition.ToOption(),
                    SectionColors: SectionColors.ToOption(),
                    SectionOutlineColor: SectionOutlineColor.ToOption(),
                    SectionOutlineWidth: SectionOutlineWidth.ToOption(),
                    SectionOutlineMultiWidth: SectionOutlineMultiWidth.ToOption(),
                    SectionOutline: SectionOutline.ToOption(),
                    Marker: Marker.ToOption(),
                    TextInfo: TextInfo.ToOption(),
                    Direction: Direction.ToOption(),
                    Hole: Hole.ToOption(),
                    Rotation: Rotation.ToOption(),
                    Sort: Sort.ToOption(),
                    UseDefaults: UseDefaults.ToOption()
                );

        /// <summary>
        /// Creates a FunnelArea chart.
        ///
        /// FunnelArea charts visualize stages in a process using area-encoded trapezoids, which can be used to show data in a part-to-whole representation similar to a piechart,
        /// wherein each item appears in a single stage. See also the "funnel" chart for a different approach to visualizing funnel data.
        /// </summary>
        /// <param name="values">Sets the values of the sectors</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover</param>
        /// <param name="ShowLegend">Determines whether or not an item corresponding to this trace is shown in the legend.</param>
        /// <param name="Opacity">Sets the opactity of the trace</param>
        /// <param name="MultiOpacity">Sets the opactity of individual datum markers</param>
        /// <param name="Labels">Sets the sector labels. If `labels` entries are duplicated, the associated `values` are summed.</param>
        /// <param name="Text">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="MultiText">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="TextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="MultiTextPosition">Sets the positions of the `text` elements with respects to the (x,y) coordinates.</param>
        /// <param name="SectionColors">Sets the colors associated with each section.</param>
        /// <param name="SectionOutlineColor">Sets the color of the section outline.</param>
        /// <param name="SectionOutlineWidth">Sets the width of the section outline.</param>
        /// <param name="SectionOutlineMultiWidth">Sets the width of each individual section outline.</param>
        /// <param name="SectionOutline">Sets the section outline (use this for more finegrained control than the other section outline-associated arguments).</param>
        /// <param name="Marker">Sets the marker of this trace.</param>
        /// <param name="TextInfo">Determines which trace information appear on the graph.</param>
        /// <param name="AspectRatio"></param>
        /// <param name="BaseRatio"></param>
        /// <param name="UseDefaults">If set to false, ignore the global default settings set in `Defaults`</param>
        public static GenericChart.GenericChart FunnelArea<ValuesType, LabelsType, TextType>(
            IEnumerable<ValuesType> values, 
            Optional<string> Name = default, 
            Optional<bool> ShowLegend = default, 
            Optional<double> Opacity = default,
            Optional<IEnumerable<double>> MultiOpacity = default, 
            Optional<IEnumerable<LabelsType>> Labels = default, 
            Optional<TextType> Text = default, 
            Optional<IEnumerable<TextType>> MultiText = default, 
            Optional<StyleParam.TextPosition> TextPosition = default,
            Optional<IEnumerable<StyleParam.TextPosition>> MultiTextPosition = default,
            Optional<IEnumerable<Color>> SectionColors = default, 
            Optional<Color> SectionOutlineColor = default, 
            Optional<double> SectionOutlineWidth = default, 
            Optional<IEnumerable<double>> SectionOutlineMultiWidth = default, 
            Optional<Line> SectionOutline = default, 
            Optional<Marker> Marker = default, 
            Optional<StyleParam.TextInfo> TextInfo = default, 
            Optional<double> AspectRatio = default, 
            Optional<double> BaseRatio = default, 
            Optional<bool> UseDefaults = default
        )
            where ValuesType : IConvertible
            where LabelsType : IConvertible
            where TextType   : IConvertible
            =>
                Plotly.NET.ChartDomain.Chart.FunnelArea<ValuesType, LabelsType, TextType>(
                    values: values,
                    Name: Name.ToOption(),
                    ShowLegend: ShowLegend.ToOption(),
                    Opacity: Opacity.ToOption(),
                    MultiOpacity: MultiOpacity.ToOption(),
                    Labels: Labels.ToOption(),
                    Text: Text.ToOption(),
                    MultiText: MultiText.ToOption(),
                    TextPosition: TextPosition.ToOption(),
                    MultiTextPosition: MultiTextPosition.ToOption(),
                    SectionColors: SectionColors.ToOption(),
                    SectionOutlineColor: SectionOutlineColor.ToOption(),
                    SectionOutlineWidth: SectionOutlineWidth.ToOption(),
                    SectionOutlineMultiWidth: SectionOutlineMultiWidth.ToOption(),
                    SectionOutline: SectionOutline.ToOption(),
                    Marker: Marker.ToOption(),
                    TextInfo: TextInfo.ToOption(),
                    AspectRatio: AspectRatio.ToOption(),
                    BaseRatio: BaseRatio.ToOption(),
                    UseDefaults: UseDefaults.ToOption()
                );

        /// <summary>
        /// Creates a sunburst chart, which visualizes hierarchical data spanning outward radially from root to leaves.
        ///
        /// The hierarchy is defined by labels and parents attributes. The root starts from the center and children are added to the outer rings.
        /// </summary>
        /// <param name="labels">Sets the labels of each of the sectors.</param>
        /// <param name="parents">Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be "ids" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.</param>
        /// <param name="Values">Sets the values associated with each of the sectors.</param>
        /// <param name="Ids">Assigns id labels to each datum. These ids for object constancy of data points during animation.</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover</param>
        /// <param name="ShowLegend">Determines whether or not an item corresponding to this trace is shown in the legend.</param>
        /// <param name="Opacity">Sets the opactity of the trace</param>
        /// <param name="MultiOpacity">Sets the opactity of individual datum markers</param>
        /// <param name="Text">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="MultiText">Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a "text" flag and "hovertext" is not set, these elements will be seen in the hover labels.</param>
        /// <param name="SectionColors">Sets the colors associated with each section.</param>
        /// <param name="SectionColorScale">Sets the colorscale for the section values</param>
        /// <param name="ShowSectionColorScale">Wether or not to show the section colorbar</param>
        /// <param name="ReverseSectionColorScale">Wether or not to show the section colorscale</param>
        /// <param name="SectionOutlineColor">Sets the color of the section outline.</param>
        /// <param name="SectionOutlineWidth">Sets the width of the section outline.</param>
        /// <param name="SectionOutlineMultiWidth">Sets the width of each individual section outline.</param>
        /// <param name="SectionOutline">Sets the section outline (use this for more finegrained control than the other section outline-associated arguments).</param>
        /// <param name="Marker">Sets the marker of this trace.</param>
        /// <param name="TextInfo">Determines which trace information appear on the graph.</param>
        /// <param name="BranchValues">Determines how the items in `values` are summed. When set to "total", items in `values` are taken to be value of all its descendants. When set to "remainder", items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.</param>
        /// <param name="Count">Determines default for `values` when it is not provided, by inferring a 1 for each of the "leaves" and/or "branches", otherwise 0.</param>
        /// <param name="Root">Sets the styles fot the root of this trace.</param>
        /// <param name="Leaf">Sets the styles fot the leaves of this trace.</param>
        /// <param name="Level">Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an "id" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.</param>
        /// <param name="MaxDepth">Sets the number of rendered sectors from any given `level`. Set `maxdepth` to "-1" to render all the levels in the hierarchy.</param>
        /// <param name="Rotation">Rotates the whole diagram counterclockwise by some angle. By default the first slice starts at 3 o'clock.</param>
        /// <param name="Sort">Determines whether or not the sectors are reordered from largest to smallest.</param>
        /// <param name="UseDefaults">If set to false, ignore the global default settings set in `Defaults`</param>
        public static GenericChart.GenericChart Sunburst<LabelsType, ParentsType, ValuesType, IdsType, TextType>(
            IEnumerable<LabelsType> labels,
            IEnumerable<ParentsType> parents,
            Optional<IEnumerable<ValuesType>> Values = default,
            Optional<IEnumerable<IdsType>> Ids = default,
            Optional<string> Name = default,
            Optional<bool> ShowLegend = default,
            Optional<double> Opacity = default,
            Optional<IEnumerable<double>> MultiOpacity = default,
            Optional<TextType> Text = default,
            Optional<IEnumerable<TextType>> MultiText = default,
            Optional<IEnumerable<Color>> SectionColors = default,
            Optional<StyleParam.Colorscale> SectionColorScale = default,
            Optional<bool> ShowSectionColorScale = default,
            Optional<bool> ReverseSectionColorScale = default,
            Optional<Color> SectionOutlineColor = default,
            Optional<double> SectionOutlineWidth = default,
            Optional<IEnumerable<double>> SectionOutlineMultiWidth = default,
            Optional<Line> SectionOutline = default,
            Optional<Marker> Marker = default,
            Optional<StyleParam.TextInfo> TextInfo = default,
            Optional<StyleParam.BranchValues> BranchValues = default,
            Optional<string> Count = default,
            Optional<SunburstRoot> Root = default,
            Optional<SunburstLeaf> Leaf = default,
            Optional<string> Level = default,
            Optional<int> MaxDepth = default,
            Optional<int> Rotation = default,
            Optional<bool> Sort = default,
            Optional<bool> UseDefaults = default
        )
            where LabelsType : IConvertible
            where ParentsType : IConvertible
            where ValuesType : IConvertible
            where IdsType : IConvertible
            where TextType : IConvertible
            =>
                Plotly.NET.ChartDomain.Chart.Sunburst<LabelsType, ParentsType, ValuesType, IdsType, TextType>(
                    labels: labels,
                    parents: parents,
                    Values: Values.ToOption(),
                    Ids: Ids.ToOption(),
                    Name: Name.ToOption(),
                    ShowLegend: ShowLegend.ToOption(),
                    Opacity: Opacity.ToOption(),
                    MultiOpacity: MultiOpacity.ToOption(),
                    Text: Text.ToOption(),
                    MultiText: MultiText.ToOption(),
                    SectionColors: SectionColors.ToOption(),
                    SectionColorScale: SectionColorScale.ToOption(),
                    ShowSectionColorScale: ShowSectionColorScale.ToOption(),
                    ReverseSectionColorScale: ReverseSectionColorScale.ToOption(),
                    SectionOutlineColor: SectionOutlineColor.ToOption(),
                    SectionOutlineWidth: SectionOutlineWidth.ToOption(),
                    SectionOutlineMultiWidth: SectionOutlineMultiWidth.ToOption(),
                    SectionOutline: SectionOutline.ToOption(),
                    Marker: Marker.ToOption(),
                    TextInfo: TextInfo.ToOption(),
                    BranchValues: BranchValues.ToOption(),
                    Count: Count.ToOption(),
                    Root: Root.ToOption(),
                    Leaf: Leaf.ToOption(),
                    Level: Level.ToOption(),
                    MaxDepth: MaxDepth.ToOption(),
                    Rotation: Rotation.ToOption(),
                    Sort: Sort.ToOption(),
                    UseDefaults: UseDefaults.ToOption()
                );


        /// <summary>
        /// Creates an Indicator chart.
        ///
        /// An indicator is used to visualize a single `value` along with some contextual information such as `steps` or a `threshold`, using a combination of three visual elements: a number, a delta, and/or a gauge.
        /// Deltas are taken with respect to a `reference`.
        /// Gauges can be either angular or bullet (aka linear) gauges.
        /// </summary>
        /// <param name="value">Sets the number to be displayed.</param>
        /// <param name="mode">Determines how the value is displayed on the graph. `number` displays the value numerically in text. `delta` displays the difference to a reference value in text. Finally, `gauge` displays the value graphically on an axis.</param>
        /// <param name="Range">Sets the Range of the Gauge axis</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover.</param>
        /// <param name="Title">Sets the title of this trace.</param>
        /// <param name="Domain">Sets the domain of this trace.</param>
        /// <param name="Align">Sets the horizontal alignment of the `text` within the box. Note that this attribute has no effect if an angular gauge is displayed: in this case, it is always centered</param>
        /// <param name="DeltaReference"></param>
        /// <param name="Delta">Sets how the delta to the delta reference is displayed</param>
        /// <param name="Number">Sets the styles of the displayed number</param>
        /// <param name="GaugeShape">Sets the shape of the gauge</param>
        /// <param name="Gauge">Sets the styles of the gauge</param>
        /// <param name="ShowGaugeAxis">Wether or not to show the gauge axis</param>
        /// <param name="GaugeAxis">Sets the gauge axis</param>
        /// <param name="UseDefaults"></param>
        public static GenericChart.GenericChart Indicator<ValueType>(
            ValueType value,
            StyleParam.IndicatorMode mode,
            Optional<StyleParam.Range> Range = default,
            Optional<string> Name = default,
            Optional<string> Title = default,
            Optional<Domain> Domain = default,
            Optional<StyleParam.IndicatorAlignment> Align = default,
            Optional<ValueType> DeltaReference = default,
            Optional<IndicatorDelta> Delta = default,
            Optional<IndicatorNumber> Number = default,
            Optional<StyleParam.IndicatorGaugeShape> GaugeShape = default,
            Optional<IndicatorGauge> Gauge = default,
            Optional<bool> ShowGaugeAxis = default,
            Optional<LinearAxis> GaugeAxis = default,
            Optional<bool> UseDefaults = default
        )
            where ValueType : IConvertible
            =>
                Plotly.NET.ChartDomain.Chart.Indicator<ValueType>(
                    value: value,
                    mode: mode,
                    Range: Range.ToOption(),
                    Name: Name.ToOption(),
                    Title: Title.ToOption(),
                    Domain: Domain.ToOption(),
                    Align: Align.ToOption(),
                    DeltaReference: DeltaReference.ToOption(),
                    Delta: Delta.ToOption(),
                    Number: Number.ToOption(),
                    GaugeShape: GaugeShape.ToOption(),
                    Gauge: Gauge.ToOption(),
                    ShowGaugeAxis: ShowGaugeAxis.ToOption(),
                    GaugeAxis: GaugeAxis.ToOption(),
                    UseDefaults: UseDefaults.ToOption()
                );

    }
}
