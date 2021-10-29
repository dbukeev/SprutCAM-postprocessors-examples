// This file may be autogenerated, do not place meaningful code here. 
// Use it only to define a list of nc-words (registers) that may appear 
// in blocks of the nc-file.
namespace SprutTechnology.SCPostprocessor
{
    ///<summary>A class that defines the nc-file - main output file that should be generated by the postprocessor.</summary>
    public partial class LSFile: TTextNCFile
    {
        ///<summary>The block of the nc-file is an ordered list of nc-words</summary>
        public NCBlock Block;

        ///<summary>Automatic block numbers counter</summary>
        // public CountingNCWord BlockN = new CountingNCWord("N{######}", 1, 1, 1);

        ///<summary>Joint value formatter</summary>
        public NumericNCWord J = new NumericNCWord("{-000.000}", 0);

        ///<summary>External axis value formatter</summary>
        public NumericNCWord E = new NumericNCWord("{-####.000}", 0);

        ///<summary>X, Y, Z, W, P, R value formatter</summary>
        public NumericNCWord C = new NumericNCWord("{-000!000}", 0);

        public LSFile(): base()
        {
            Block = new NCBlock(this);
            OnInit();
        }

    }
}