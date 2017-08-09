using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using MathNet.Numerics.IntegralTransforms;
using Mechatronics.MathToolBox;

namespace BodeDiagram
{
    class DataAnalysisCW
    {
        private List<double> OS_TCMD_LIST { get; set; }
        private List<double> OS_FRTCM_LIST { set; get; }
        private List<double> OS_FREQUENCY_LIST { set; get; }
        private List<double> FREQUENCIES_LIST { set; get; }
        private List<Complex> MAX_OS_FRTCM_LIST { get; set; }
        private List<Complex> MAX_OS_TCMD_LIST { get; set; }

        public List<double> MAGNITUDE_BODE { get; set; }
        public List<double> PHASE_BODE { get; set; }
        public List<double> FREQUENCY_BODE { get; set; }

        private void readCSV(TextReader file)
        {
            var csv = new CsvReader(file);
            while(csv.Read())
            {
                OS_TCMD_LIST.Add(csv.GetField<double>(0));
                OS_FRTCM_LIST.Add(csv.GetField<double>(1));
                OS_FREQUENCY_LIST.Add(csv.GetField<double>(2));
            }
        }

        private void extractFreq()
        {
            for(int i = 0; i <= OS_FREQUENCY_LIST.Count - 2; i++)
            {
                if(OS_FREQUENCY_LIST[i] != OS_FREQUENCY_LIST[i+1] || i == (OS_FREQUENCY_LIST.Count - 2))
                {
                    FREQUENCIES_LIST.Add(OS_FREQUENCY_LIST[i]);
                }
            }
        }

        private void extractMaxs()
        {
            int j = 0;
            double FRTCM_MAX = 0;
            double TCMD_MAX = 0;
            int INDEX_FRTCM_MAX = 0;
            int INDEX_TCMD_MAX = 0;

            List<Complex> u_AUX_OS_FRTCM = new List<Complex>();
            List<Complex> u_AUX_OS_TCMD = new List<Complex>();
            List<Double> AUX_OS_TCMD = new List<double>();
            List<Double> AUX_OS_FRTCM = new List<double>();
            for (int i = 0; i<OS_FREQUENCY_LIST.Count; i++)
            {
                if(OS_FREQUENCY_LIST[i] == FREQUENCIES_LIST[j])
                {
                    AUX_OS_TCMD.Add(OS_TCMD_LIST[i]);
                    AUX_OS_FRTCM.Add(OS_FRTCM_LIST[i]);
                }
                else
                {
                    int n = AUX_OS_FRTCM.Count;

                    Double[] uT_AUX_OS_FRTCM_REAL = new Double[n];
                    Double[] uT_AUX_OS_FRTCM_IMAG = new Double[n];
                    Double[] uT_AUX_OS_TCMD_REAL  = new Double[n];
                    Double[] uT_AUX_OS_TCMD_IMAG  = new Double[n];

                    for (int k = 0; k < n; k++)
                    {
                        uT_AUX_OS_FRTCM_REAL[k] = AUX_OS_FRTCM[k];
                        uT_AUX_OS_FRTCM_IMAG[k] = 0;
                        uT_AUX_OS_TCMD_REAL[k]  = AUX_OS_TCMD[k];
                        uT_AUX_OS_TCMD_IMAG[k]  = 0;
                    }

                    Fourier.Forward(uT_AUX_OS_FRTCM_REAL, uT_AUX_OS_FRTCM_IMAG, FourierOptions.NoScaling);
                    Fourier.Forward(uT_AUX_OS_TCMD_REAL, uT_AUX_OS_TCMD_IMAG, FourierOptions.NoScaling);

                    for (int k = 0; k < n / 2; k++)
                    {
                        Complex AUX = new Complex(2.0 / n * uT_AUX_OS_FRTCM_REAL[k], 2.0 / n * uT_AUX_OS_FRTCM_IMAG[k]);
                        u_AUX_OS_FRTCM.Add(AUX);
                        AUX = new Complex(2.0 / n * uT_AUX_OS_TCMD_REAL[k], 2.0 / n * uT_AUX_OS_TCMD_IMAG[k]);
                        u_AUX_OS_TCMD.Add(AUX);
                    }

                    double[] MAG_u_AUX_OS_FRTCM = new double[n];
                    double[] MAG_u_AUX_OS_TCMD  = new double[n];

                    for(int k = 0; k < n / 2; k++)
                    {
                        MAG_u_AUX_OS_FRTCM[k] = u_AUX_OS_FRTCM[k].Mag;
                        MAG_u_AUX_OS_TCMD[k]  = u_AUX_OS_TCMD[k].Mag;
                    }

                    FRTCM_MAX = MAG_u_AUX_OS_FRTCM.Max();
                    TCMD_MAX  = MAG_u_AUX_OS_TCMD.Max();
                    INDEX_FRTCM_MAX = MAG_u_AUX_OS_FRTCM.ToList().IndexOf(FRTCM_MAX);
                    INDEX_TCMD_MAX = MAG_u_AUX_OS_TCMD.ToList().IndexOf(TCMD_MAX);

                    MAX_OS_FRTCM_LIST.Add(u_AUX_OS_FRTCM[INDEX_FRTCM_MAX]);
                    MAX_OS_TCMD_LIST.Add(u_AUX_OS_TCMD[INDEX_TCMD_MAX]);

                    AUX_OS_TCMD.Clear();
                    AUX_OS_FRTCM.Clear();
                    u_AUX_OS_FRTCM.Clear();
                    u_AUX_OS_TCMD.Clear();

                    AUX_OS_TCMD.Add(OS_TCMD_LIST[i]);
                    AUX_OS_FRTCM.Add(OS_FRTCM_LIST[i]);
                    j++;
                }
            }
        }

        private void dataTrans()
        {
            for (int i = 0; i < MAX_OS_FRTCM_LIST.Count; i++)
            {
                Complex H = new Complex();
                H.Real = ((MAX_OS_FRTCM_LIST[i].Real * MAX_OS_TCMD_LIST[i].Real) + (MAX_OS_FRTCM_LIST[i].Imag * MAX_OS_TCMD_LIST[i].Imag)) / (Math.Pow(MAX_OS_TCMD_LIST[i].Real, 2) + Math.Pow(MAX_OS_TCMD_LIST[i].Imag, 2));
                H.Imag = ((MAX_OS_FRTCM_LIST[i].Imag * MAX_OS_TCMD_LIST[i].Real) - (MAX_OS_FRTCM_LIST[i].Real * MAX_OS_TCMD_LIST[i].Imag)) / (Math.Pow(MAX_OS_TCMD_LIST[i].Real, 2) + Math.Pow(MAX_OS_TCMD_LIST[i].Imag, 2));
                MAGNITUDE_BODE.Add(-20.0 * Math.Log10(H.Mag));

                double v = -H.Phs;
                PHASE_BODE.Add(v);
                //double v = Math.Atan2(H.Imag, H.Real);
                //if (v < 0)
                //    v = v + 2 * Math.PI;;
                //PHASE_BODE.Add(-v * 180 / Math.PI);
            }
            FREQUENCY_BODE = FREQUENCIES_LIST;
        }

        public DataAnalysisCW()
        {
            OS_TCMD_LIST = new List<double>();
            OS_FRTCM_LIST = new List<double>();
            OS_FREQUENCY_LIST = new List<double>();
            FREQUENCIES_LIST = new List<double>();
            MAGNITUDE_BODE = new List<double>();
            PHASE_BODE = new List<double>();
            FREQUENCY_BODE = new List<double>();
            MAX_OS_FRTCM_LIST = new List<Complex>();
            MAX_OS_TCMD_LIST = new List<Complex>();
        }

        public void getPlottingData(TextReader file)
        {
            readCSV(file);
            extractFreq();
            extractMaxs();
            dataTrans();
        }

        public void clearPlottingData()
        {
            OS_TCMD_LIST.Clear();
            OS_FRTCM_LIST.Clear();
            OS_FREQUENCY_LIST.Clear();
            FREQUENCIES_LIST.Clear();
            MAX_OS_FRTCM_LIST.Clear();
            MAX_OS_TCMD_LIST.Clear();
            MAGNITUDE_BODE.Clear();
            PHASE_BODE.Clear();
            FREQUENCY_BODE.Clear();
        }
    }
}