using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2c
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;

        private void input2Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2TextBox.Text);
                byte2Textbox.Text = byte2.ToString();
            }
            catch (Exception) { byte2Textbox.Text = "*Error*"; }
            try
            {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyte2Textbox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2Textbox.Text = "*Error*"; }
            try
            {
                short2 = Convert.ToInt16(input2TextBox.Text);
                short2Textbox.Text = short2.ToString();
            }
            catch (Exception) { short2Textbox.Text = "*Error*"; }
            try
            {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushort2Textbox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2Textbox.Text = "*Error*"; }
            try
            {
                int2 = Convert.ToInt32(input2TextBox.Text);
                int2Textbox.Text = int2.ToString();
            }
            catch (Exception) { int2Textbox.Text = "*Error*"; }
            try
            {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uint2Textbox.Text = uint2.ToString();
            }
            catch (Exception) { uint2Textbox.Text = "*Error*"; }
            try
            {
                long2 = Convert.ToInt64(input2TextBox.Text);
                long2Textbox.Text = long2.ToString();
            }
            catch (Exception) { long2Textbox.Text = "*Error*"; }
            try
            {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulong2Textbox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2Textbox.Text = "*Error*"; }
            try
            {
                float2 = Convert.ToSingle(input2TextBox.Text);
                float2Textbox.Text = float2.ToString();
            }
            catch (Exception) { float2Textbox.Text = "*Error*"; }
            try
            {
                double2 = Convert.ToDouble(input2TextBox.Text);
                double2Textbox.Text = double2.ToString();
            }
            catch (Exception) { double2Textbox.Text = "*Error*"; }
            try
            {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimal2Textbox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2Textbox.Text = "*Error*"; }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try {
                byte3 = Convert.ToByte(byte1 + byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "*Error*"; byte1 = 0; }
            try
            {
                sbyte3 = Convert.ToSByte(sbyte1 + sbyte2);
                sbyte3Textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3Textbox.Text = "*Error*"; sbyte1 = 0; }
            try
            {
                short3 = Convert.ToInt16(short1 + short2);
                short3Textbox.Text = short3.ToString();
            }
            catch (Exception) { short3Textbox.Text = "*Error*"; short1 = 0; }
            try
            {
                ushort3 = Convert.ToUInt16(ushort1 + ushort2);
                ushort3Textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3Textbox.Text = "*Error*"; ushort1 = 0; }
            try
            {
                int3 = checked(int1 + int2);
                int3Textbox.Text = int3.ToString();
            }
            catch (Exception) { int3Textbox.Text = "*Error*"; int1 = 0; }
            try
            {
                uint3 = checked(uint1 + uint2);
                uint3Textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3Textbox.Text = "*Error*"; uint1 = 0; }
            try
            {
                long3 = checked(long1 + long2);
                long3Textbox.Text = long3.ToString();
            }
            catch (Exception) { long3Textbox.Text = "*Error*"; long1 = 0; }
            try
            {
                ulong3 = checked(ulong1 + ulong2);
                ulong3Textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3Textbox.Text = "*Error*"; ulong1 = 0; }
            try
            {
                float3 = checked(float1 + float2);
                float3Textbox.Text = float3.ToString();
            }
            catch (Exception) { float3Textbox.Text = "*Error*"; float1 = 0; }
            try
            {
                double3 = checked(double1 + double2);
                double3Textbox.Text = double3.ToString();
            }
            catch (Exception) { double3Textbox.Text = "*Error*"; double1 = 0; }
            try
            {
                decimal3 = checked(decimal1 + decimal2);
                decimal3Textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3Textbox.Text = "*Error*"; decimal1 = 0; }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte3 = Convert.ToByte(byte1 - byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "*Error*"; byte1 = 0; }
            try
            {
                sbyte3 = Convert.ToSByte(sbyte1 - sbyte2);
                sbyte3Textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3Textbox.Text = "*Error*"; sbyte1 = 0; }
            try
            {
                short3 = Convert.ToInt16(short1 - short2);
                short3Textbox.Text = short3.ToString();
            }
            catch (Exception) { short3Textbox.Text = "*Error*"; short1 = 0; }
            try
            {
                ushort3 = Convert.ToUInt16(ushort1 - ushort2);
                ushort3Textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3Textbox.Text = "*Error*"; ushort1 = 0; }
            try
            {
                int3 = checked(int1 - int2);
                int3Textbox.Text = int3.ToString();
            }
            catch (Exception) { int3Textbox.Text = "*Error*"; int1 = 0; }
            try
            {
                uint3 = checked(uint1 - uint2);
                uint3Textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3Textbox.Text = "*Error*"; uint1 = 0; }
            try
            {
                long3 = checked(long1 - long2);
                long3Textbox.Text = long3.ToString();
            }
            catch (Exception) { long3Textbox.Text = "*Error*"; long1 = 0; }
            try
            {
                ulong3 = checked(ulong1 - ulong2);
                ulong3Textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3Textbox.Text = "*Error*"; ulong1 = 0; }
            try
            {
                float3 = checked(float1 - float2);
                float3Textbox.Text = float3.ToString();
            }
            catch (Exception) { float3Textbox.Text = "*Error*"; float1 = 0; }
            try
            {
                double3 = checked(double1 - double2);
                double3Textbox.Text = double3.ToString();
            }
            catch (Exception) { double3Textbox.Text = "*Error*"; double1 = 0; }
            try
            {
                decimal3 = checked(decimal1 - decimal2);
                decimal3Textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3Textbox.Text = "*Error*"; decimal1 = 0; }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte3 = Convert.ToByte(byte1 * byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "*Error*"; byte1 = 0; }
            try
            {
                sbyte3 = Convert.ToSByte(sbyte1 * sbyte2);
                sbyte3Textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3Textbox.Text = "*Error*"; sbyte1 = 0; }
            try
            {
                short3 = Convert.ToInt16(short1 * short2);
                short3Textbox.Text = short3.ToString();
            }
            catch (Exception) { short3Textbox.Text = "*Error*"; short1 = 0; }
            try
            {
                ushort3 = Convert.ToUInt16(ushort1 * ushort2);
                ushort3Textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3Textbox.Text = "*Error*"; ushort1 = 0; }
            try
            {
                int3 = checked(int1 * int2);
                int3Textbox.Text = int3.ToString();
            }
            catch (Exception) { int3Textbox.Text = "*Error*"; int1 = 0; }
            try
            {
                uint3 = checked(uint1 * uint2);
                uint3Textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3Textbox.Text = "*Error*"; uint1 = 0; }
            try
            {
                long3 = checked(long1 * long2);
                long3Textbox.Text = long3.ToString();
            }
            catch (Exception) { long3Textbox.Text = "*Error*"; long1 = 0; }
            try
            {
                ulong3 = checked(ulong1 * ulong2);
                ulong3Textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3Textbox.Text = "*Error*"; ulong1 = 0; }
            try
            {
                float3 = checked(float1 * float2);
                float3Textbox.Text = float3.ToString();
            }
            catch (Exception) { float3Textbox.Text = "*Error*"; float1 = 0; }
            try
            {
                double3 = checked(double1 * double2);
                double3Textbox.Text = double3.ToString();
            }
            catch (Exception) { double3Textbox.Text = "*Error*"; double1 = 0; }
            try
            {
                decimal3 = checked(decimal1 * decimal2);
                decimal3Textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3Textbox.Text = "*Error*"; decimal1 = 0; }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte3 = Convert.ToByte(byte1 / byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "*Error*"; byte1 = 0; }
            try
            {
                sbyte3 = Convert.ToSByte(sbyte1 / sbyte2);
                sbyte3Textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3Textbox.Text = "*Error*"; sbyte1 = 0; }
            try
            {
                short3 = Convert.ToInt16(short1 / short2);
                short3Textbox.Text = short3.ToString();
            }
            catch (Exception) { short3Textbox.Text = "*Error*"; short1 = 0; }
            try
            {
                ushort3 = Convert.ToUInt16(ushort1 / ushort2);
                ushort3Textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3Textbox.Text = "*Error*"; ushort1 = 0; }
            try
            {
                int3 = checked(int1 / int2);
                int3Textbox.Text = int3.ToString();
            }
            catch (Exception) { int3Textbox.Text = "*Error*"; int1 = 0; }
            try
            {
                uint3 = checked(uint1 / uint2);
                uint3Textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3Textbox.Text = "*Error*"; uint1 = 0; }
            try
            {
                long3 = checked(long1 / long2);
                long3Textbox.Text = long3.ToString();
            }
            catch (Exception) { long3Textbox.Text = "*Error*"; long1 = 0; }
            try
            {
                ulong3 = checked(ulong1 / ulong2);
                ulong3Textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3Textbox.Text = "*Error*"; ulong1 = 0; }
            try
            {
                float3 = checked(float1 / float2);
                float3Textbox.Text = float3.ToString();
            }
            catch (Exception) { float3Textbox.Text = "*Error*"; float1 = 0; }
            try
            {
                double3 = checked(double1 / double2);
                double3Textbox.Text = double3.ToString();
            }
            catch (Exception) { double3Textbox.Text = "*Error*"; double1 = 0; }
            try
            {
                decimal3 = checked(decimal1 / decimal2);
                decimal3Textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3Textbox.Text = "*Error*"; decimal1 = 0; }
        }

        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;
        public Form1()
        {
            InitializeComponent();
        }

        private void setMinButton_Click(object sender, EventArgs e)
        {
            

            byte1 = Byte.MinValue; byte1Textbox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; sbyte1Textbox.Text = sbyte1.ToString();
            short1 = short.MinValue; short1Textbox.Text = short1.ToString();
            ushort1 = ushort.MinValue; ushort1Textbox.Text = ushort1.ToString();
            int1 = int.MinValue; int1Textbox.Text = int1.ToString();
            uint1 = uint.MinValue; uint1Textbox.Text = uint1.ToString();
            long1 = long.MinValue; long1Textbox.Text = long1.ToString();
            ulong1 = ulong.MinValue; ulong1Textbox.Text = ulong1.ToString();
            float1 = float.MinValue; float1Textbox.Text = float1.ToString();
            double1 = double.MinValue; double1Textbox.Text = double1.ToString();
            decimal1 = decimal.MinValue; decimal1Textbox.Text = decimal1.ToString();
        }

        private void setMaxButton_Click(object sender, EventArgs e)
        {
            

            byte2 = Byte.MaxValue; byte2Textbox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2Textbox.Text = sbyte2.ToString();
            short2 = short.MaxValue; short2Textbox.Text = short2.ToString();
            ushort2 = ushort.MaxValue; ushort2Textbox.Text = ushort2.ToString();
            int2 = int.MaxValue; int2Textbox.Text = int2.ToString();
            uint2 = uint.MaxValue; uint2Textbox.Text = uint2.ToString();
            long2 = long.MaxValue; long2Textbox.Text = long2.ToString();
            ulong2 = ulong.MaxValue; ulong2Textbox.Text = ulong2.ToString();
            float2 = float.MaxValue; float2Textbox.Text = float2.ToString();
            double2 = double.MaxValue; double2Textbox.Text = double2.ToString();
            decimal2 = decimal.MaxValue; decimal2Textbox.Text = decimal2.ToString();
        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                byte1 = Convert.ToByte(input1TextBox.Text);
                byte1Textbox.Text = byte1.ToString();
            }
            catch (Exception) { byte1Textbox.Text = "*Error*"; byte1 = 0; }
            try
            {
                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyte1Textbox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyte1Textbox.Text = "*Error*"; sbyte1 = 0; }
            try
            {
                short1 = Convert.ToInt16(input1TextBox.Text);
                short1Textbox.Text = short1.ToString();
            }
            catch (Exception) { short1Textbox.Text = "*Error*"; short1 = 0; }
            try
            {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushort1Textbox.Text = ushort1.ToString();
            }
            catch (Exception) { ushort1Textbox.Text = "*Error*"; ushort1 = 0; }
            try
            {
                int1 = Convert.ToInt32(input1TextBox.Text);
                int1Textbox.Text = int1.ToString();
            }
            catch (Exception) { int1Textbox.Text = "*Error*"; int1 = 0; }
            try
            {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
                uint1Textbox.Text = uint1.ToString();
            }
            catch (Exception) { uint1Textbox.Text = "*Error*"; uint1 = 0; }
            try
            {
                long1 = Convert.ToInt64(input1TextBox.Text);
                long1Textbox.Text = long1.ToString();
            }
            catch (Exception) { long1Textbox.Text = "*Error*"; long1 = 0; }
            try
            {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulong1Textbox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1Textbox.Text = "*Error*"; ulong1 = 0; }
            try
            {
                float1 = Convert.ToSingle(input1TextBox.Text);
                float1Textbox.Text = float1.ToString();
            }
            catch (Exception) { float1Textbox.Text = "*Error*"; float1 = 0.0f; }
            try
            {
                double1 = Convert.ToDouble(input1TextBox.Text);
                double1Textbox.Text = double1.ToString();
            }
            catch (Exception) { double1Textbox.Text = "*Error*"; double1 = 0.0; }
            try
            {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimal1Textbox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1Textbox.Text = "*Error*"; decimal1 = 0m; }

        }
    }
}
