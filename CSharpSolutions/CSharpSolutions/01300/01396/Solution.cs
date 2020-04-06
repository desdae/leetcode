using System;
using System.Collections.Generic;

namespace CSharpSolutions._01300._01396
{
    public class UndergroundSystem
    {

        //id => <stationName, time>
        private Dictionary<int, Tuple<string, int>> custState = new Dictionary<int, Tuple<string, int>>();
        //stationName => <stationName => [total time, times]>
        private Dictionary<string, Dictionary<string, int[]>> travelTimes = new Dictionary<string, Dictionary<string, int[]>>();


        public UndergroundSystem()
        {

        }

        public void CheckIn(int id, string stationName, int t)
        {
            custState[id] = new Tuple<string, int>(stationName, t);
        }

        public void CheckOut(int id, string stationName, int t)
        {
            var st = custState[id];
            int delta = t - st.Item2;
            if (!travelTimes.ContainsKey(st.Item1))
            {
                travelTimes[st.Item1] = new Dictionary<string, int[]>();
            }
            if (!travelTimes[st.Item1].ContainsKey(stationName))
            {
                travelTimes[st.Item1][stationName] = new int[2];
            }
            travelTimes[st.Item1][stationName][0]++;
            travelTimes[st.Item1][stationName][1] += delta;
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            return (double)travelTimes[startStation][endStation][1] / (double)travelTimes[startStation][endStation][0];
        }
    }
    /**
     * Your UndergroundSystem object will be instantiated and called as such:
     * UndergroundSystem obj = new UndergroundSystem();
     * obj.CheckIn(id,stationName,t);
     * obj.CheckOut(id,stationName,t);
     * double param_3 = obj.GetAverageTime(startStation,endStation);
     */
}
