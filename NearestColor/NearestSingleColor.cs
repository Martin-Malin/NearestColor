namespace NearestColor
{
    internal class NearestSingleColor
    {
        private readonly byte _color;

        private readonly byte MaxValue = byte.MaxValue;

        public string Value
        {
            get
            {
                if (HigherDifference() > _color)
                    return "00";
                else
                    return "FF";
            }
        }

        public NearestSingleColor(string color)
        {
            _color = Convert.ToByte(color, 16);
        }

        private byte HigherDifference()
        {
            return (byte)(MaxValue - _color);
        }
    }
}
