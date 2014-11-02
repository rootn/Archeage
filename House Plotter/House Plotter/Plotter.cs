using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using ArcheBuddy.Bot.Classes;

namespace Plotter.Source
{
    public class housePlotter : Core
    {
        private Creature housePlot = null;
        private PlotForm plotForm;
        private Thread formThread;
        public bool bCancelRequested = false;

        public static string GetPluginAuthor()
        {
            return "RootN";
        }

        public static string GetPluginVersion()
        {
            return "1.0.0.0";
        }

        public static string GetPluginDescription()
        {
            return "House Plotter";
        }

        public void selectHouse(int pos1, int pos2)
        {
            foreach (var obj in getCreatures())
            {
                if (obj.X == pos1 && obj.Y == pos2)
                {
                    SetTarget(obj);
                    housePlot = obj;
                }

            }
        }

        public void spamHouse(uint houseId, int pos1, int pos2, int pos3)
        {
            selectHouse(pos1, pos2);
            Item design = getInvItem(houseId);
            bool loopStart = true;
            while (loopStart)
            {
                if (!isExists(housePlot))
                {
                    design.ConstructHouse(pos1, pos2, pos3, 0);
                    loopStart = false;
                }
            }
        }

        public void markHouseOnMap(int pos1, int pos2, int pos3)
        {
            SetMapPos(pos1, pos2, pos3);
        }

        public void runForm()
        {
            try
            {
                Application.Run(plotForm);
            }
            catch (Exception error)
            {
                Log(error.ToString());
            }
        }

        //Call on plugin start
        public void PluginRun()
        {
            ClearLogs();

            plotForm = new PlotForm();
            plotForm.setPlotter(this);
            formThread = new Thread(runForm);
            formThread.Start();

            while (!bCancelRequested)
                Thread.Sleep(100);

            StopPlugin("House Plotter\\House Plotter.dll");
        }

        //Call on plugin stop
        public void PluginStop()
        {
            bCancelRequested = true;

            try
            {
                if (plotForm != null)
                {
                    plotForm.Invoke(new Action(() => plotForm.Close()));
                    plotForm.Invoke(new Action(() => plotForm.Dispose()));
                }

                Application.Exit();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

            try
            {
                formThread.Abort();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
