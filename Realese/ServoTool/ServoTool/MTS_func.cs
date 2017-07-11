using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectSmplData;
using ViliPetek.LinearAlgebra;

namespace MTS
{
    class MTS_func
    {
        private itri2fanucWrapper Itri2Fanuc_func;
        public void GetHndl(itri2fanucWrapper I2F)
        {
            Itri2Fanuc_func = I2F;
        }
        double[] Org_Value = new double[5];
        public string FrqResponseStart(short Axis, int FrqStart, int FrqEnd, int DisAmp, int WaveNum, int PosGain)
        {
            double SmplTime = 0;
            if (FrqStart < 10)
            {
                for (double i = FrqStart; i <= 9; i++)
                {
                    SmplTime += (1 / i) * 1000 * 4 * WaveNum;
                }
                for (double i = 10; i < FrqEnd; i += 5)
                {
                    SmplTime += (1 / i) * 1000 * 4 * WaveNum;
                }
            }
            else
            {
                FrqStart = (FrqStart / 5) * 5;
                for (double i = FrqStart; i < FrqEnd; i += 5)
                {
                    SmplTime += (1 / i) * 1000 * 4 * WaveNum;
                }
            }

            sbyte[] SmplAxis = new sbyte[3] { (sbyte)(Axis), (sbyte)(Axis), (sbyte)(Axis) };
            short[] SmplType = new short[3] { 3, 32, 31 };
            string ret = Itri2Fanuc_func.SamplingStart(3, SmplAxis, SmplType, 512, (int)SmplTime + 4000, 0);
            if (ret != "EW_OK") return "SamplingStart Error : " + ret;
            Itri2Fanuc_func.ReadParameterVal(2326);
            Org_Value[0] = Itri2Fanuc_func.PrmContainer[Axis - 1];
            Itri2Fanuc_func.ReadParameterVal(2327);
            Org_Value[1] = Itri2Fanuc_func.PrmContainer[Axis - 1];
            Itri2Fanuc_func.ReadParameterVal(2328);
            Org_Value[2] = Itri2Fanuc_func.PrmContainer[Axis - 1];
            Itri2Fanuc_func.ReadParameterVal(2329);
            Org_Value[3] = Itri2Fanuc_func.PrmContainer[Axis - 1];
            Itri2Fanuc_func.ReadParameterVal(1825);
            Org_Value[4] = Itri2Fanuc_func.PrmContainer[Axis - 1];
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2326, DisAmp);
            if (ret != "EW_OK") return "Error(No.2326) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2327, FrqStart);
            if (ret != "EW_OK") return "Error(No.2327) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2328, FrqEnd);
            if (ret != "EW_OK") return "Error(No.2327) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2329, WaveNum);
            if (ret != "EW_OK") return "Error(No.2329) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 1825, PosGain);
            if (ret != "EW_OK") return "Error(No.1825) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2270, 128);
            if (ret != "EW_OK") return "Error(No.2270) : " + ret;
            return "Start input disturbance";
        }
        public string FrqResponseEnd(short Axis)
        {
            string ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2270, 0);
            if (ret != "EW_OK") return "Error(No.2270) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2326, (int)Org_Value[0]);
            if (ret != "EW_OK") return "Error(No.2326) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2327, (int)(Org_Value[1]));
            if (ret != "EW_OK") return "Error(No.2327) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2328, (int)(Org_Value[2]));
            if (ret != "EW_OK") return "Error(No.2327) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 2329, (int)(Org_Value[3]));
            if (ret != "EW_OK") return "Error(No.2329) : " + ret;
            ret = Itri2Fanuc_func.WriteParameterVal(Axis, 1825, (int)(Org_Value[4]));
            if (ret != "EW_OK") return "Error(No.1825) : " + ret;
            return "Stop input disturbance";
        }

        public void BodePlot(ref List<List<float>> FrqDataList)
        {
            List<float> FrqList = new List<float>();
            List<float> Ftest = new List<float>();
            List<List<float>> BodeDataList = new List<List<float>>();
            BodeDataList.Add(new List<float>());
            BodeDataList.Add(new List<float>());
            BodeDataList.Add(new List<float>());
            //   int Index = 0;

            while (true)
            {
                if (FrqDataList[1][0] == 0)
                {
                    Ftest.Add(FrqDataList[0][0]);
                    for (int i = 0; i < 3; i++)
                    {
                        FrqDataList[i].RemoveAt(0);
                    }
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                int last = FrqDataList[1].Count - 1;
                if (FrqDataList[1][last] == 0)
                {
                    Ftest.Add(FrqDataList[0][last]);
                    for (int i = 0; i < 3; i++)
                    {
                        FrqDataList[i].RemoveAt(last);
                    }
                }
                else
                {
                    break;
                }
            }
            //float b = FrqDataList[2].Average();
            float b = -0.175022362F;
            float DisAvg = Ftest.Average();
            //float K = -0.142118886F;
            int DataLength = FrqDataList[0].Count;
            float DisturbanceMax = FrqDataList[1].Max(), DisturbanceMin = FrqDataList[1].Min();
            for (int i = 0; i < DataLength - 1; i++)
            {
                FrqList.Add(FrqDataList[0][i]);
                if (FrqDataList[2][i + 1] != FrqDataList[2][i] || i == DataLength - 1)
                {
                    double[] xx = new double[FrqList.Count];
                    double[] yy = new double[FrqList.Count];
                    for (int j = 0; j < FrqList.Count; j++)
                    {
                        xx[j] = j;
                        yy[j] = FrqList[j];
                    }
                    //FrqDataList[2].GetRange(PhaseStart, (int)PeriodTimes).CopyTo(yy);
                    var polyfit = new PolyFit(xx, yy, 5);
                    var fitted = polyfit.Fit(xx);

                    BodeDataList[0].Add(FrqDataList[2][i]);
                    BodeDataList[1].Add((float)(20 * Math.Log10((fitted.Max() - fitted.Min()) / (DisturbanceMax - DisturbanceMin))));
                    FrqList.Clear();
                }
            }

            double PeriodTimes = 0, PhaseDelay = 0;
            int TCMDMaxIndex = 0, TCMDMinIndex = 0, FRTCMMaxIndex = 0, FRTCMMinIndex, PhaseStart = 0, PhaseEnd = 0, cctest = 0;
            //Index = 0;
            List<float> TCMDList = new List<float>();
            List<float> FRTCMList = new List<float>();
            for (int i = 0; i < DataLength - 1; i++)
            {
                if (FrqDataList[2][i + 1] != FrqDataList[2][i] || i == DataLength - 1)
                {
                    PeriodTimes = (1 / FrqDataList[2][i]) * 1000 * 4;
                    PhaseStart = (i - (int)PeriodTimes + 1);
                    float Amp = (FrqDataList[0].GetRange(PhaseStart, (int)PeriodTimes).Max() - FrqDataList[0].GetRange(PhaseStart, (int)PeriodTimes).Min()) / 2;
                    double[] xx = new double[(int)PeriodTimes];
                    double[] yy = new double[(int)PeriodTimes];
                    for (int j = 0; j < (int)PeriodTimes; j++)
                    {
                        xx[j] = j;
                        yy[j] = FrqDataList[0][j + PhaseStart];
                    }
                    //FrqDataList[2].GetRange(PhaseStart, (int)PeriodTimes).CopyTo(yy);
                    var polyfit = new PolyFit(xx, yy, 4);
                    var fitted = polyfit.Fit(xx);

                    if ((FrqDataList[1][PhaseStart] >= 0 && fitted[0] >= 0) || (FrqDataList[1][PhaseStart] <= 0 && fitted[0] <= 0))
                    {
                        if (FrqDataList[1][PhaseStart] >= 0)
                        {
                            for (int j = PhaseStart; j < i + 1; j++)
                            {
                                if (FrqDataList[1][j] < 0)
                                {
                                    FRTCMMaxIndex = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < (int)PeriodTimes; j++)
                            {
                                if (fitted[j] < DisAvg)
                                {
                                    TCMDMaxIndex = j + PhaseStart;
                                    break;
                                }
                            }
                        }
                        else if (FrqDataList[1][PhaseStart] <= 0)
                        {
                            for (int j = PhaseStart; j < i + 1; j++)
                            {
                                if (FrqDataList[1][j] > 0)
                                {
                                    FRTCMMaxIndex = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < (int)PeriodTimes; j++)
                            {
                                if (fitted[j] > DisAvg)
                                {
                                    TCMDMaxIndex = j + PhaseStart;
                                    break;
                                }
                            }
                        }
                        PhaseDelay = (double)(FRTCMMaxIndex - TCMDMaxIndex) / PeriodTimes * 360;
                    }
                    else
                    {
                        if (FrqDataList[1][PhaseStart] >= 0)
                        {
                            for (int j = PhaseStart; j < i + 1; j++)
                            {
                                if (FrqDataList[1][j] < 0)
                                {
                                    FRTCMMaxIndex = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < (int)PeriodTimes; j++)
                            {
                                if (fitted[j] > DisAvg)
                                {
                                    TCMDMaxIndex = j + PhaseStart;
                                    break;
                                }
                            }
                        }
                        else if (FrqDataList[1][PhaseStart] <= 0)
                        {
                            for (int j = PhaseStart; j < i + 1; j++)
                            {
                                if (FrqDataList[1][j] > 0)
                                {
                                    FRTCMMaxIndex = j;
                                    break;
                                }
                            }
                            for (int j = 0; j < (int)PeriodTimes; j++)
                            {
                                if (fitted[j] < DisAvg)
                                {
                                    TCMDMaxIndex = j + PhaseStart;
                                    break;
                                }
                            }
                        }
                        PhaseDelay = (double)(FRTCMMaxIndex - TCMDMaxIndex) / PeriodTimes * 360 - 180;
                    }
                    while (PhaseDelay < -330)
                        PhaseDelay += 360;
                    while (PhaseDelay > 30)
                        PhaseDelay += -360;
                    BodeDataList[2].Add((float)PhaseDelay);
                }
            }
            //for (int i = 0; i < DataLength - 1; i++)
            //{                
            //    if (FrqDataList[2][i + 1] != FrqDataList[2][i] || i == DataLength - 1)
            //    {
            //        PeriodTimes = (1 / FrqDataList[2][i]) * 1000 * 4;

            //        double[] xx = new double[(int)PeriodTimes];
            //        double[] yy = new double[(int)PeriodTimes];
            //        for (int j = 0; j < (int)PeriodTimes; j++)
            //        {
            //            xx[j] = j;
            //            yy[j] = FrqDataList[0][j + PhaseStart];
            //        }

            //        var polyfit = new PolyFit(xx, yy, 10);
            //        var fitted = polyfit.Fit(xx);


            //        FRTCMMaxIndex = FrqDataList[1].GetRange(i, (int)PeriodTimes).IndexOf(FrqDataList[1].GetRange(i, (int)PeriodTimes).Max());
            //        FRTCMMinIndex = FrqDataList[1].GetRange(i, (int)PeriodTimes).IndexOf(FrqDataList[1].GetRange(i, (int)PeriodTimes).Min());
            //        TCMDMaxIndex = FrqDataList[2].GetRange(i, (int)PeriodTimes).IndexOf(FrqDataList[2].GetRange(i, (int)PeriodTimes).Max());
            //        TCMDMinIndex = FrqDataList[2].GetRange(i, (int)PeriodTimes).IndexOf(FrqDataList[2].GetRange(i, (int)PeriodTimes).Min());
            //        PhaseDelay = -(TCMDMaxIndex - FRTCMMaxIndex) / PeriodTimes * 360;
            //        if (PhaseDelay < -350)
            //            PhaseDelay += 360;
            //        else if (PhaseDelay > 10)
            //            PhaseDelay += -360;
            //        BodeDataList[2].Add((float)PhaseDelay);
            //    }
            //}

            FrqDataList.Clear();
            FrqDataList = BodeDataList;
        }
        
    }
}
