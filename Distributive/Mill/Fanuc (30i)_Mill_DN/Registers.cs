// This file may be autogenerated, do not place meaningful code here. 
// Use it only to define a list of nc-words (registers) that may appear 
// in blocks of the nc-file.
namespace SprutTechnology.SCPostprocessor
{
    ///<summary>A class that defines the nc-file - main output file that should be generated by the postprocessor.</summary>
    public partial class NCFile: TTextNCFile
    {
        ///<summary>The block of the nc-file is an ordered list of nc-words</summary>
        public NCBlock Block;

        ///<summary>Automatic block numbers counter</summary>
        public CountingNCWord BlockN = new CountingNCWord("N{######}", 1, 1, 1);

        ///<summary>G90, G91 - absolute or incremental motion mode selection</summary>
        public NumericNCWord GAbsInc = new NumericNCWord("G{##}", 90);

        ///<summary>G20, G21 - current measurements inch or mm</summary>
        public NumericNCWord GMeasure = new NumericNCWord("G{##}", 21);

        ///<summary>G54-G59 - current workpiece coordinate system number</summary>
        public NumericNCWord GWCS = new NumericNCWord("G{##}", 54);

        ///<summary>G68.2, G69 - Local coordinate system activation-deactivation</summary>
        public NumericNCWord GLCS = new NumericNCWord("G{##.#}", 69);

        ///<summary>G04 - delay of nc programm execution</summary>
        public NumericNCWord GDelay = new NumericNCWord("G{00}", 04);

        ///<summary>Pause duration in seconds</summary>
        public NumericNCWord XDelay = new NumericNCWord("X{-#####!###}", 0);

        ///<summary>G17, G18, G19 - current plane code</summary>
        public NumericNCWord GPlane = new NumericNCWord("G{##}", 17);

        ///<summary>G50 - maximal spindle rotations definition code</summary>
        public NumericNCWord GSMax = new NumericNCWord("G{##}", 50);

        ///<summary>G96, G97 - spindle rotation mode: const surface speed or const rotations per min</summary>
        public NumericNCWord GCssRpm = new NumericNCWord("G{##}", 96);

        ///<summary>Spindle speed value</summary>
        public NumericNCWord S = new NumericNCWord("S{####}", 0);

        ///<summary>M03, M04, M05 - spindle switch on-off code</summary>
        public NumericNCWord MSpindle = new NumericNCWord("M{00}", 5);

        ///<summary>G94, G95 - current feed mode: per minute or per rev</summary>
        public NumericNCWord GFeed = new NumericNCWord("G{##}", 17);

        ///<summary>G00, G01, G02, G03 - current mode of an interpolation</summary>
        public NumericNCWord GInterp = new NumericNCWord("G{00}", 0);

        ///<summary>G28 - return to home position, or G53 - physic axes motion</summary>
        public NumericNCWord GHome = new NumericNCWord("G{##}", 28);

        ///<summary>G80, G81, G82... - canned cycle code</summary>
        public NumericNCWord GCycle = new NumericNCWord("G{##}", 80);

        ///<summary>G43, G43.4, G49 - length compensation mode: on, off</summary>
        public NumericNCWord GLCompens = new NumericNCWord("G{##.#}", 49);

        ///<summary>H - length corretor number</summary>
        public NumericNCWord HLCompens = new NumericNCWord("H{###}", 0);

        ///<summary>G40, G41, G42 - radius compensation mode: off, left, right</summary>
        public NumericNCWord GRCompens = new NumericNCWord("G{##}", 40);

        ///<summary>D - radius compensation corrector number</summary>
        public NumericNCWord DRCompens = new NumericNCWord("D{####}", 0);

        ///<summary>X coordinate of the movement</summary>
        public NumericNCWord X = new NumericNCWord("X{-#####!###}", 0);

        ///<summary>Y coordinate of the movement</summary>
        public NumericNCWord Y = new NumericNCWord("Y{-#####!###}", 0);

        ///<summary>Z coordinate of the movement</summary>
        public NumericNCWord Z = new NumericNCWord("Z{-#####!###}", 0);

        ///<summary>A axis angle</summary>
        public NumericNCWord A = new NumericNCWord("A{-#####!###}", 0);

        ///<summary>B axis angle</summary>
        public NumericNCWord B = new NumericNCWord("B{-#####!###}", 0);

        ///<summary>C axis angle</summary>
        public NumericNCWord C = new NumericNCWord("C{-#####!###}", 0);

        ///<summary>U - incremental X axis movement</summary>
        public NumericNCWord U = new NumericNCWord("U{-#####!###}", 0);

        ///<summary>V - incremental Y axis movement</summary>
        public NumericNCWord V = new NumericNCWord("V{-#####!###}", 0);

        ///<summary>W - incremental Z axis movement</summary>
        public NumericNCWord W = new NumericNCWord("W{-#####!###}", 0);

        ///<summary>H - incremental C axis movement</summary>
        public NumericNCWord H = new NumericNCWord("H{-#####!###}", 0);

        ///<summary>Circle radius</summary>
        public NumericNCWord R = new NumericNCWord("R{-#####!###}", 0);

        ///<summary>Safe return level R in hole machining cycles</summary>
        public NumericNCWord RSafeLevel = new NumericNCWord("R{-#####!###}", 0);

        ///<summary>X coordinate of the circle center point</summary>
        public NumericNCWord I = new NumericNCWord("I{-#####!###}", 0);

        ///<summary>Y coordinate of the circle center point</summary>
        public NumericNCWord J = new NumericNCWord("J{-#####!###}", 0);

        ///<summary>Z coordinate of the circle center point</summary>
        public NumericNCWord K = new NumericNCWord("K{-#####!###}", 0);

        ///<summary>Feedrate value of the movement</summary>
        public NumericNCWord F = new NumericNCWord("F{#####}", 0);

        ///<summary>Tool number</summary>
        public NumericNCWord T = new NumericNCWord("T{####}", 0);

        ///<summary>Pause onhole cycle bottom or top level (G82 and others)</summary>
        public NumericNCWord PDrillPause = new NumericNCWord("P{#####}", 0);

        ///<summary>P - subroutine number in call instruction M98 P####</summary>
        public NumericNCWord PSubCall = new NumericNCWord("P{#####}", 0);

        ///<summary>Q - step for G73, G83 and others drill cycles</summary>
        public NumericNCWord QStep = new NumericNCWord("P{#####.###}", 0);

        ///<summary>M00, M01, M02, M30 - auxiliary M codes</summary>
        public NumericNCWord M = new NumericNCWord("M{00}", 0);

        ///<summary>M08, M09 - coolant switch on-off codes</summary>
        public NumericNCWord MCoolant = new NumericNCWord("M{00}", 09);

        ///<summary>M593, M592 - A axis brake switch on-off codes</summary>
        public NumericNCWord MABrake = new NumericNCWord("M{###}", 592);

        ///<summary>M595, M594 - B axis brake switch on-off codes</summary>
        public NumericNCWord MBBrake = new NumericNCWord("M{###}", 594);

        ///<summary>M597, M596 - C axis brake switch on-off codes</summary>
        public NumericNCWord MCBrake = new NumericNCWord("M{###}", 596);

        ///<summary>Text comment at the end of the block</summary>
        public TextNCWord TrailingComment = new TextNCWord("( ", "", " )");

        public NCFile(): base()
        {
            Block = new NCBlock(this, 
                BlockN,
                GAbsInc,
                GMeasure,
                GWCS,
                GLCS,
                GDelay,
                GPlane,
                GSMax,
                GCssRpm,
                GFeed,
                GInterp,
                GHome,
                GCycle,
                GLCompens,
                GRCompens,
                X,
                Y,
                Z,
                A,
                B,
                C,
                U,
                V,
                W,
                H,
                HLCompens,
                DRCompens,
                R,
                RSafeLevel,
                I,
                J,
                K,
                XDelay,
                F,
                PDrillPause,
                QStep,
                S,
                T,
                M,
                MSpindle,
                MCoolant,
                MABrake,
                MBBrake,
                MCBrake,
                PSubCall,
                TrailingComment
            );
            OnInit();
        }

    }
}