using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Xml;
using System.Configuration;
using System.Xml.Serialization;
using System.Net;
using System.Drawing;
using Integrator.BL;

namespace Tweaker
{
    using Repository.DAL;

  
    class Program
    {
        static FanoramaStagingEntities entity = new FanoramaStagingEntities();

        private static IntegratorEntities1 integratorEntity = new IntegratorEntities1();
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Change name of microsites.");
            Console.WriteLine("2 - Change name of profiles.");
            Console.WriteLine("3 - Check emails in users");
            Console.WriteLine("4 - Fix duplicates");
            Console.WriteLine("5 - Fix Not exitst one with Regular");
            Console.WriteLine("6 - Add fanid for each microsite");
            Console.WriteLine("7 - Add dealers ranking");
            Console.WriteLine("8 - Remove duplicate players");
            Console.WriteLine("9 - Switch back to previous description");
            Console.WriteLine("9 - Switch back to previous description");
            Console.WriteLine("10 - Change the name of the microsites in taa_microsite");
            Console.WriteLine("11 - Copy images to fanid");
            Console.WriteLine("12 - Download microsites has been created using xml files to have logos");
            Console.WriteLine("13 - Change http://dev. to http://thefanorama.com");
            Console.WriteLine("14 - Insert new sizes.");


            string[] filesMicrosite =
                {
                    "microsite.wEx-099024.0.xml", "microsite.wEx-099092.0.xml",
                    "microsite.wEx-099120.0.xml", "microsite.wEx-099125.0.xml",
                    "microsite.wEx-099126.0.xml", "microsite.wEx-099127.0.xml",
                    "microsite.wEx-099128.0.xml", "microsite.wEx-099153.0.xml",
                    "microsite.wEx-099180.0.xml", "microsite.wEx-099182.0.xml",
                    "microsite.wEx-099183.0.xml", "microsite.wEx-099184.0.xml",
                    "microsite.wEx-099185.0.xml", "microsite.wEx-099194.0.xml",
                    "microsite.wEx-099210.0.xml", "microsite.wEx-099211.0.xml",
                    "microsite.wEx-099212.0.xml", "microsite.wEx-099213.0.xml",
                    "microsite.wEx-099214.0.xml", "microsite.wEx-099215.0.xml",
                    "microsite.wEx-099226.0.xml", "microsite.wEx-099228.0.xml",
                    "microsite.wEx-099235.0.xml", "microsite.wEx-099236.0.xml",
                    "microsite.wEx-099240.0.xml", "microsite.wEx-099241.0.xml",
                    "microsite.wEx-099265.0.xml", "microsite.wEx-099270.0.xml",
                    "microsite.wEx-099274.0.xml", "microsite.wEx-099275.0.xml",
                    "microsite.wEx-099276.0.xml", "microsite.wEx-099277.0.xml",
                    "microsite.wEx-099278.0.xml", "microsite.wEx-099295.0.xml",
                    "microsite.wEx-099307.0.xml", "microsite.wEx-099308.0.xml",
                    "microsite.wEx-099317.0.xml", "microsite.wEx-099330.0.xml",
                    "microsite.wEx-099338.0.xml", "microsite.wEx-099339.0.xml",
                    "microsite.wEx-099343.0.xml", "microsite.wEx-099350.0.xml",
                    "microsite.wEx-099353.0.xml", "microsite.wEx-099356.0.xml",
                    "microsite.wEx-099357.0.xml", "microsite.wEx-099358.0.xml",
                    "microsite.wEx-099359.0.xml", "microsite.wEx-099365.0.xml",
                    "microsite.wEx-099372.0.xml", "microsite.wEx-099388.0.xml",
                    "microsite.wEx-099489.0.xml", "microsite.wEx-099491.0.xml",
                    "microsite.wEx-099500.0.xml", "microsite.wEx-099509.0.xml",
                    "microsite.wEx-099518.0.xml", "microsite.wEx-099578.0.xml",
                    "microsite.wEx-099582.0.xml", "microsite.wEx-099585.0.xml",
                    "microsite.wEx-099595.0.xml", "microsite.wEx-099609.0.xml",
                    "microsite.wEx-099610.0.xml", "microsite.wEx-099616.0.xml",
                    "microsite.wEx-099619.0.xml", "microsite.wEx-099632.0.xml",
                    "microsite.wEx-099637.0.xml", "microsite.wEx-099662.0.xml",
                    "microsite.wEx-099684.0.xml", "microsite.wEx-099686.0.xml",
                    "microsite.wEx-099755.0.xml", "microsite.wEx-099757.0.xml",
                    "microsite.wEx-099770.0.xml", "microsite.wEx-099772.0.xml",
                    "microsite.wEx-099799.0.xml", "microsite.wEx-099801.0.xml",
                    "microsite.wEx-099823.0.xml", "microsite.wEx-099833.0.xml",
                    "microsite.wEx-099870.0.xml", "microsite.wEx-099871.0.xml",
                    "microsite.wEx-099872.0.xml", "microsite.wEx-099873.0.xml",
                    "microsite.wEx-099876.0.xml", "microsite.wEx-099877.0.xml",
                    "microsite.wEx-099880.0.xml", "microsite.wEx-099891.0.xml",
                    "microsite.wEx-099923.0.xml", "microsite.wEx-099990.0.xml",
                    "microsite.wEx-100003.0.xml", "microsite.wEx-100004.0.xml",
                    "microsite.wEx-100036.0.xml", "microsite.wEx-100044.0.xml",
                    "microsite.wEx-100045.0.xml", "microsite.wEx-100046.0.xml",
                    "microsite.wEx-100049.0.xml", "microsite.wEx-100054.0.xml",
                    "microsite.wEx-100060.0.xml", "microsite.wEx-100085.0.xml",
                    "microsite.wEx-100086.0.xml", "microsite.wEx-100095.0.xml",
                    "microsite.wEx-100102.0.xml", "microsite.wEx-100114.0.xml",
                    "microsite.wEx-100137.0.xml", "microsite.wEx-100138.0.xml",
                    "microsite.wEx-100165.0.xml", "microsite.wEx-100167.0.xml",
                    "microsite.wEx-100201.0.xml", "microsite.wEx-100214.0.xml",
                    "microsite.wEx-100232.0.xml", "microsite.wEx-100246.0.xml",
                    "microsite.wEx-100247.0.xml", "microsite.wEx-100248.0.xml",
                    "microsite.wEx-100251.0.xml", "microsite.wEx-100267.0.xml",
                    "microsite.wEx-100271.0.xml", "microsite.wEx-100294.0.xml",
                    "microsite.wEx-100295.0.xml", "microsite.wEx-100310.0.xml",
                    "microsite.wEx-100332.0.xml", "microsite.wEx-100335.0.xml",
                    "microsite.wEx-100339.0.xml", "microsite.wEx-100350.0.xml",
                    "microsite.wEx-100365.0.xml", "microsite.wEx-100367.0.xml",
                    "microsite.wEx-100380.0.xml", "microsite.wEx-100413.0.xml",
                    "microsite.wEx-100416.0.xml", "microsite.wEx-100469.0.xml",
                    "microsite.wEx-100487.0.xml", "microsite.wEx-100507.0.xml",
                    "microsite.wEx-100518.0.xml", "microsite.wEx-100519.0.xml",
                    "microsite.wEx-100525.0.xml", "microsite.wEx-100526.0.xml",
                    "microsite.wEx-100539.0.xml", "microsite.wEx-100540.0.xml",
                    "microsite.wEx-100543.0.xml", "microsite.wEx-100545.0.xml",
                    "microsite.wEx-100550.0.xml", "microsite.wEx-100714.0.xml",
                    "microsite.wEx-100723.0.xml", "microsite.wEx-100728.0.xml",
                    "microsite.wEx-100729.0.xml", "microsite.wEx-100730.0.xml",
                    "microsite.wEx-100733.0.xml", "microsite.wEx-100889.0.xml",
                    "microsite.wEx-100910.0.xml", "microsite.wEx-100911.0.xml",
                    "microsite.wEx-100912.0.xml", "microsite.wEx-100913.0.xml",
                    "microsite.wEx-100928.0.xml", "microsite.wEx-100936.0.xml",
                    "microsite.wEx-100937.0.xml", "microsite.wEx-100939.0.xml",
                    "microsite.wEx-100944.0.xml", "microsite.wEx-100945.0.xml",
                    "microsite.wEx-100950.0.xml", "microsite.wEx-100963.0.xml",
                    "microsite.wEx-100988.0.xml", "microsite.wEx-100991.0.xml",
                    "microsite.wEx-100992.0.xml", "microsite.wEx-101033.0.xml",
                    "microsite.wEx-101034.0.xml", "microsite.wEx-101035.0.xml",
                    "microsite.wEx-101036.0.xml", "microsite.wEx-101037.0.xml",
                    "microsite.wEx-101039.0.xml", "microsite.wEx-101040.0.xml",
                    "microsite.wEx-101042.0.xml", "microsite.wEx-101045.0.xml",
                    "microsite.wEx-101072.0.xml", "microsite.wEx-101086.0.xml",
                    "microsite.wEx-101087.0.xml", "microsite.wEx-101088.0.xml",
                    "microsite.wEx-101090.0.xml", "microsite.wEx-101091.0.xml",
                    "microsite.wEx-101093.0.xml", "microsite.wEx-101104.0.xml",
                    "microsite.wEx-101153.0.xml", "microsite.wEx-101154.0.xml",
                    "microsite.wEx-101155.0.xml", "microsite.wEx-101156.0.xml",
                    "microsite.wEx-101160.0.xml", "microsite.wEx-101165.0.xml",
                    "microsite.wEx-101172.0.xml", "microsite.wEx-101184.0.xml",
                    "microsite.wEx-101193.0.xml", "microsite.wEx-101240.0.xml",
                    "microsite.wEx-101263.0.xml", "microsite.wEx-101265.0.xml",
                    "microsite.wEx-101276.0.xml", "microsite.wEx-101277.0.xml",
                    "microsite.wEx-101279.0.xml", "microsite.wEx-101280.0.xml",
                    "microsite.wEx-101281.0.xml", "microsite.wEx-101284.0.xml",
                    "microsite.wEx-101285.0.xml", "microsite.wEx-101286.0.xml",
                    "microsite.wEx-101331.0.xml", "microsite.wEx-101332.0.xml",
                    "microsite.wEx-101333.0.xml", "microsite.wEx-101334.0.xml",
                    "microsite.wEx-101335.0.xml", "microsite.wEx-101336.0.xml",
                    "microsite.wEx-101337.0.xml", "microsite.wEx-101338.0.xml",
                    "microsite.wEx-101339.0.xml", "microsite.wEx-101340.0.xml",
                    "microsite.wEx-101341.0.xml", "microsite.wEx-101344.0.xml",
                    "microsite.wEx-101345.0.xml", "microsite.wEx-101346.0.xml",
                    "microsite.wEx-101347.0.xml", "microsite.wEx-101349.0.xml",
                    "microsite.wEx-101351.0.xml", "microsite.wEx-101371.0.xml",
                    "microsite.wEx-101379.0.xml", "microsite.wEx-101382.0.xml",
                    "microsite.wEx-101384.0.xml", "microsite.wEx-101415.0.xml",
                    "microsite.wEx-101462.0.xml", "microsite.wEx-101463.0.xml",
                    "microsite.wEx-101464.0.xml", "microsite.wEx-101465.0.xml",
                    "microsite.wEx-101470.0.xml", "microsite.wEx-101476.0.xml",
                    "microsite.wEx-101483.0.xml", "microsite.wEx-101487.0.xml",
                    "microsite.wEx-101488.0.xml", "microsite.wEx-101490.0.xml",
                    "microsite.wEx-101491.0.xml", "microsite.wEx-101492.0.xml",
                    "microsite.wEx-101493.0.xml", "microsite.wEx-101495.0.xml",
                    "microsite.wEx-101537.0.xml", "microsite.wEx-101541.0.xml",
                    "microsite.wEx-101543.0.xml", "microsite.wEx-101544.0.xml",
                    "microsite.wEx-101546.0.xml", "microsite.wEx-101550.0.xml",
                    "microsite.wEx-101551.0.xml", "microsite.wEx-101552.0.xml",
                    "microsite.wEx-101553.0.xml", "microsite.wEx-101554.0.xml",
                    "microsite.wEx-101670.0.xml", "microsite.wEx-101671.0.xml",
                    "microsite.wEx-101672.0.xml", "microsite.wEx-101689.0.xml",
                    "microsite.wEx-101740.0.xml", "microsite.wEx-101745.0.xml",
                    "microsite.wEx-101755.0.xml", "microsite.wEx-101759.0.xml",
                    "microsite.wEx-101762.0.xml", "microsite.wEx-101763.0.xml",
                    "microsite.wEx-101815.0.xml", "microsite.wEx-101852.0.xml",
                    "microsite.wEx-101859.0.xml", "microsite.wEx-101896.0.xml",
                    "microsite.wEx-101917.0.xml", "microsite.wEx-101998.0.xml",
                    "microsite.wEx-102012.0.xml", "microsite.wEx-102075.0.xml",
                    "microsite.wEx-102083.0.xml", "microsite.wEx-102089.0.xml",
                    "microsite.wEx-102106.0.xml", "microsite.wEx-102222.0.xml",
                    "microsite.wEx-102285.0.xml", "microsite.wEx-102286.0.xml",
                    "microsite.wEx-102294.0.xml", "microsite.wEx-102296.0.xml",
                    "microsite.wEx-102310.0.xml", "microsite.wEx-102340.0.xml",
                    "microsite.wEx-102344.0.xml", "microsite.wEx-102439.0.xml",
                    "microsite.wEx-102446.0.xml", "microsite.wEx-102447.0.xml",
                    "microsite.wEx-102448.0.xml", "microsite.wEx-102450.0.xml",
                    "microsite.wEx-102494.0.xml", "microsite.wEx-102495.0.xml",
                    "microsite.wEx-102496.0.xml", "microsite.wEx-102498.0.xml",
                    "microsite.wEx-102551.0.xml", "microsite.wEx-102658.0.xml",
                    "microsite.wEx-102659.0.xml", "microsite.wEx-102660.0.xml",
                    "microsite.wEx-102669.0.xml", "microsite.wEx-102714.0.xml",
                    "microsite.wEx-102764.0.xml", "microsite.wEx-102803.0.xml",
                    "microsite.wEx-102807.0.xml", "microsite.wEx-102816.0.xml",
                    "microsite.wEx-102853.0.xml", "microsite.wEx-102987.0.xml",
                    "microsite.wEx-102998.0.xml", "microsite.wEx-103043.0.xml",
                    "microsite.wEx-103044.0.xml", "microsite.wEx-103060.0.xml",
                    "microsite.wEx-103170.0.xml", "microsite.wEx-103185.0.xml",
                    "microsite.wEx-103323.0.xml", "microsite.wEx-103389.0.xml",
                    "microsite.wEx-103450.0.xml", "microsite.wEx-103619.0.xml",
                    "microsite.wEx-103620.0.xml", "microsite.wEx-103693.0.xml",
                    "microsite.wEx-103755.0.xml", "microsite.wEx-103757.0.xml",
                    "microsite.wEx-103758.0.xml", "microsite.wEx-103778.0.xml",
                    "microsite.wEx-104085.0.xml", "microsite.wEx-104095.0.xml",
                    "microsite.wEx-104096.0.xml", "microsite.wEx-104097.0.xml",
                    "microsite.wEx-104101.0.xml", "microsite.wEx-104146.0.xml",
                    "microsite.wEx-104157.0.xml", "microsite.wEx-104266.0.xml",
                    "microsite.wEx-104286.0.xml", "microsite.wEx-104307.0.xml",
                    "microsite.wEx-104347.0.xml", "microsite.wEx-104358.0.xml",
                    "microsite.wEx-104359.0.xml", "microsite.wEx-104489.0.xml",
                    "microsite.wEx-104529.0.xml", "microsite.wEx-104592.0.xml",
                    "microsite.wEx-104594.0.xml", "microsite.wEx-104645.0.xml",
                    "microsite.wEx-104763.0.xml", "microsite.wEx-104809.0.xml",
                    "microsite.wEx-104813.0.xml", "microsite.wEx-104814.0.xml",
                    "microsite.wEx-104815.0.xml", "microsite.wEx-104816.0.xml",
                    "microsite.wEx-104821.0.xml", "microsite.wEx-104823.0.xml",
                    "microsite.wEx-104831.0.xml", "microsite.wEx-104834.0.xml",
                    "microsite.wEx-104838.0.xml", "microsite.wEx-104845.0.xml",
                    "microsite.wEx-104846.0.xml", "microsite.wEx-104851.0.xml",
                    "microsite.wEx-104852.0.xml", "microsite.wEx-104853.0.xml",
                    "microsite.wEx-104856.0.xml", "microsite.wEx-104858.0.xml",
                    "microsite.wEx-104866.0.xml", "microsite.wEx-104873.0.xml",
                    "microsite.wEx-104878.0.xml", "microsite.wEx-104889.0.xml",
                    "microsite.wEx-104890.0.xml", "microsite.wEx-104892.0.xml",
                    "microsite.wEx-104994.0.xml", "microsite.wEx-104998.0.xml",
                    "microsite.wEx-105008.0.xml", "microsite.wEx-105011.0.xml",
                    "microsite.wEx-105012.0.xml", "microsite.wEx-105013.0.xml",
                    "microsite.wEx-105024.0.xml", "microsite.wEx-105029.0.xml",
                    "microsite.wEx-105032.0.xml", "microsite.wEx-105156.0.xml",
                    "microsite.wEx-105208.0.xml", "microsite.wEx-105219.0.xml",
                    "microsite.wEx-105221.0.xml", "microsite.wEx-105262.0.xml",
                    "microsite.wEx-105299.0.xml", "microsite.wEx-105300.0.xml",
                    "microsite.wEx-105301.0.xml", "microsite.wEx-105331.0.xml",
                    "microsite.wEx-105334.0.xml", "microsite.wEx-105335.0.xml",
                    "microsite.wEx-105336.0.xml", "microsite.wEx-105337.0.xml",
                    "microsite.wEx-105338.0.xml", "microsite.wEx-105339.0.xml",
                    "microsite.wEx-105366.0.xml", "microsite.wEx-105371.0.xml",
                    "microsite.wEx-105374.0.xml", "microsite.wEx-105378.0.xml",
                    "microsite.wEx-105484.0.xml", "microsite.wEx-105489.0.xml",
                    "microsite.wEx-105492.0.xml", "microsite.wEx-105504.0.xml",
                    "microsite.wEx-105509.0.xml", "microsite.wEx-105510.0.xml",
                    "microsite.wEx-105511.0.xml", "microsite.wEx-105520.0.xml",
                    "microsite.wEx-105540.0.xml", "microsite.wEx-105541.0.xml",
                    "microsite.wEx-105542.0.xml", "microsite.wEx-105543.0.xml",
                    "microsite.wEx-105544.0.xml", "microsite.wEx-105547.0.xml",
                    "microsite.wEx-105556.0.xml", "microsite.wEx-105558.0.xml",
                    "microsite.wEx-105596.0.xml", "microsite.wEx-105597.0.xml",
                    "microsite.wEx-105598.0.xml", "microsite.wEx-105615.0.xml",
                    "microsite.wEx-105616.0.xml", "microsite.wEx-105620.0.xml",
                    "microsite.wEx-105625.0.xml", "microsite.wEx-105629.0.xml",
                    "microsite.wEx-105680.0.xml", "microsite.wEx-105736.0.xml",
                    "microsite.wEx-105770.0.xml", "microsite.wEx-105776.0.xml",
                    "microsite.wEx-105778.0.xml", "microsite.wEx-105828.0.xml",
                    "microsite.wEx-105831.0.xml", "microsite.wEx-105832.0.xml",
                    "microsite.wEx-105836.0.xml", "microsite.wEx-105838.0.xml",
                    "microsite.wEx-105839.0.xml", "microsite.wEx-105840.0.xml",
                    "microsite.wEx-105846.0.xml", "microsite.wEx-105847.0.xml",
                    "microsite.wEx-105850.0.xml", "microsite.wEx-105852.0.xml",
                    "microsite.wEx-105863.0.xml", "microsite.wEx-105880.0.xml",
                    "microsite.wEx-105885.0.xml", "microsite.wEx-105887.0.xml",
                    "microsite.wEx-105889.0.xml", "microsite.wEx-105910.0.xml",
                    "microsite.wEx-105953.0.xml", "microsite.wEx-105997.0.xml",
                    "microsite.wEx-105998.0.xml", "microsite.wEx-106003.0.xml",
                    "microsite.wEx-106017.0.xml", "microsite.wEx-106023.0.xml",
                    "microsite.wEx-106030.0.xml", "microsite.wEx-106048.0.xml",
                    "microsite.wEx-106050.0.xml", "microsite.wEx-106051.0.xml",
                    "microsite.wEx-106052.0.xml", "microsite.wEx-106053.0.xml",
                    "microsite.wEx-106054.0.xml", "microsite.wEx-106055.0.xml",
                    "microsite.wEx-106056.0.xml", "microsite.wEx-106058.0.xml",
                    "microsite.wEx-106061.0.xml", "microsite.wEx-106062.0.xml",
                    "microsite.wEx-106130.0.xml", "microsite.wEx-106138.0.xml",
                    "microsite.wEx-106139.0.xml", "microsite.wEx-106140.0.xml",
                    "microsite.wEx-106144.0.xml", "microsite.wEx-106147.0.xml",
                    "microsite.wEx-106151.0.xml", "microsite.wEx-106154.0.xml",
                    "microsite.wEx-106216.0.xml", "microsite.wEx-106224.0.xml",
                    "microsite.wEx-106249.0.xml", "microsite.wEx-106275.0.xml",
                    "microsite.wEx-106279.0.xml", "microsite.wEx-106280.0.xml",
                    "microsite.wEx-106307.0.xml", "microsite.wEx-106313.0.xml",
                    "microsite.wEx-106321.0.xml", "microsite.wEx-106322.0.xml",
                    "microsite.wEx-106342.0.xml", "microsite.wEx-106344.0.xml",
                    "microsite.wEx-106345.0.xml", "microsite.wEx-106348.0.xml",
                    "microsite.wEx-106351.0.xml", "microsite.wEx-106358.0.xml",
                    "microsite.wEx-106359.0.xml", "microsite.wEx-106360.0.xml",
                    "microsite.wEx-106418.0.xml", "microsite.wEx-106454.0.xml",
                    "microsite.wEx-106460.0.xml", "microsite.wEx-106528.0.xml",
                    "microsite.wEx-106548.0.xml", "microsite.wEx-106565.0.xml",
                    "microsite.wEx-106584.0.xml", "microsite.wEx-106586.0.xml",
                    "microsite.wEx-106588.0.xml", "microsite.wEx-106642.0.xml",
                    "microsite.wEx-106644.0.xml", "microsite.wEx-106661.0.xml",
                    "microsite.wEx-106676.0.xml", "microsite.wEx-106682.0.xml",
                    "microsite.wEx-106685.0.xml", "microsite.wEx-106690.0.xml",
                    "microsite.wEx-106691.0.xml", "microsite.wEx-106692.0.xml",
                    "microsite.wEx-106703.0.xml", "microsite.wEx-106704.0.xml",
                    "microsite.wEx-106712.0.xml", "microsite.wEx-106718.0.xml",
                    "microsite.wEx-106721.0.xml", "microsite.wEx-106765.0.xml",
                    "microsite.wEx-106789.0.xml", "microsite.wEx-106795.0.xml",
                    "microsite.wEx-106798.0.xml", "microsite.wEx-106817.0.xml",
                    "microsite.wEx-106820.0.xml", "microsite.wEx-106825.0.xml",
                    "microsite.wEx-106830.0.xml", "microsite.wEx-106864.0.xml",
                    "microsite.wEx-106882.0.xml", "microsite.wEx-106892.0.xml",
                    "microsite.wEx-106906.0.xml", "microsite.wEx-106948.0.xml",
                    "microsite.wEx-106967.0.xml", "microsite.wEx-106985.0.xml",
                    "microsite.wEx-106991.0.xml", "microsite.wEx-107029.0.xml",
                    "microsite.wEx-107030.0.xml", "microsite.wEx-107063.0.xml",
                    "microsite.wEx-107064.0.xml", "microsite.wEx-107073.0.xml",
                    "microsite.wEx-107081.0.xml", "microsite.wEx-107126.0.xml",
                    "microsite.wEx-107201.0.xml", "microsite.wEx-107215.0.xml",
                    "microsite.wEx-107226.0.xml", "microsite.wEx-107258.0.xml",
                    "microsite.wEx-107259.0.xml", "microsite.wEx-107260.0.xml",
                    "microsite.wEx-107296.0.xml", "microsite.wEx-107328.0.xml",
                    "microsite.wEx-107358.0.xml", "microsite.wEx-107359.0.xml",
                    "microsite.wEx-107361.0.xml", "microsite.wEx-107376.0.xml",
                    "microsite.wEx-107413.0.xml", "microsite.wEx-107414.0.xml",
                    "microsite.wEx-107415.0.xml", "microsite.wEx-107450.0.xml",
                    "microsite.wEx-107453.0.xml", "microsite.wEx-107485.0.xml",
                    "microsite.wEx-107511.0.xml", "microsite.wEx-107512.0.xml",
                    "microsite.wEx-107524.0.xml", "microsite.wEx-107541.0.xml",
                    "microsite.wEx-107542.0.xml", "microsite.wEx-107544.0.xml",
                    "microsite.wEx-107545.0.xml", "microsite.wEx-107557.0.xml",
                    "microsite.wEx-107564.0.xml", "microsite.wEx-107566.0.xml",
                    "microsite.wEx-107571.0.xml", "microsite.wEx-107590.0.xml",
                    "microsite.wEx-107646.0.xml", "microsite.wEx-107654.0.xml",
                    "microsite.wEx-107657.0.xml", "microsite.wEx-107679.0.xml",
                    "microsite.wEx-107747.0.xml", "microsite.wEx-107803.0.xml",
                    "microsite.wEx-107804.0.xml", "microsite.wEx-107805.0.xml",
                    "microsite.wEx-107862.0.xml", "microsite.wEx-107868.0.xml",
                    "microsite.wEx-107910.0.xml", "microsite.wEx-107913.0.xml",
                    "microsite.wEx-107953.0.xml", "microsite.wEx-107965.0.xml",
                    "microsite.wEx-107966.0.xml", "microsite.wEx-107968.0.xml",
                    "microsite.wEx-107972.0.xml", "microsite.wEx-107981.0.xml",
                    "microsite.wEx-107994.0.xml", "microsite.wEx-108000.0.xml",
                    "microsite.wEx-108014.0.xml", "microsite.wEx-108018.0.xml",
                    "microsite.wEx-108079.0.xml", "microsite.wEx-108096.0.xml",
                    "microsite.wEx-108098.0.xml", "microsite.wEx-108102.0.xml",
                    "microsite.wEx-108130.0.xml", "microsite.wEx-108186.0.xml",
                    "microsite.wEx-108187.0.xml", "microsite.wEx-108188.0.xml",
                    "microsite.wEx-108191.0.xml", "microsite.wEx-108192.0.xml",
                    "microsite.wEx-108195.0.xml", "microsite.wEx-108245.0.xml",
                    "microsite.wEx-108251.0.xml", "microsite.wEx-108252.0.xml",
                    "microsite.wEx-108255.0.xml", "microsite.wEx-108258.0.xml",
                    "microsite.wEx-108261.0.xml", "microsite.wEx-108364.0.xml",
                    "microsite.wEx-108367.0.xml", "microsite.wEx-108368.0.xml",
                    "microsite.wEx-108420.0.xml", "microsite.wEx-108426.0.xml",
                    "microsite.wEx-108427.0.xml", "microsite.wEx-108428.0.xml",
                    "microsite.wEx-108445.0.xml", "microsite.wEx-108454.0.xml",
                    "microsite.wEx-108455.0.xml", "microsite.wEx-108456.0.xml",
                    "microsite.wEx-108527.0.xml", "microsite.wEx-108570.0.xml",
                    "microsite.wEx-108574.0.xml", "microsite.wEx-108575.0.xml",
                    "microsite.wEx-108576.0.xml", "microsite.wEx-108580.0.xml",
                    "microsite.wEx-108586.0.xml", "microsite.wEx-108651.0.xml",
                    "microsite.wEx-108654.0.xml", "microsite.wEx-108656.0.xml",
                    "microsite.wEx-108684.0.xml", "microsite.wEx-108719.0.xml",
                    "microsite.wEx-108721.0.xml", "microsite.wEx-108738.0.xml",
                    "microsite.wEx-108742.0.xml", "microsite.wEx-108744.0.xml",
                    "microsite.wEx-108847.0.xml", "microsite.wEx-108894.0.xml",
                    "microsite.wEx-108919.0.xml", "microsite.wEx-108945.0.xml",
                    "microsite.wEx-108983.0.xml", "microsite.wEx-108984.0.xml",
                    "microsite.wEx-108988.0.xml", "microsite.wEx-108994.0.xml",
                    "microsite.wEx-109011.0.xml", "microsite.wEx-109012.0.xml",
                    "microsite.wEx-109053.0.xml", "microsite.wEx-109056.0.xml",
                    "microsite.wEx-109085.0.xml", "microsite.wEx-109086.0.xml",
                    "microsite.wEx-109090.0.xml", "microsite.wEx-109094.0.xml",
                    "microsite.wEx-109095.0.xml", "microsite.wEx-109096.0.xml",
                    "microsite.wEx-109128.0.xml", "microsite.wEx-109134.0.xml",
                    "microsite.wEx-109156.0.xml", "microsite.wEx-109183.0.xml",
                    "microsite.wEx-109190.0.xml", "microsite.wEx-109218.0.xml",
                    "microsite.wEx-109233.0.xml", "microsite.wEx-109266.0.xml",
                    "microsite.wEx-109268.0.xml", "microsite.wEx-109278.0.xml",
                    "microsite.wEx-109294.0.xml", "microsite.wEx-109300.0.xml",
                    "microsite.wEx-109529.0.xml", "microsite.wEx-109539.0.xml",
                    "microsite.wEx-109605.0.xml", "microsite.wEx-109635.0.xml",
                    "microsite.wEx-109644.0.xml", "microsite.wEx-109655.0.xml",
                    "microsite.wEx-109696.0.xml", "microsite.wEx-109703.0.xml",
                    "microsite.wEx-109724.0.xml", "microsite.wEx-109737.0.xml",
                    "microsite.wEx-109787.0.xml", "microsite.wEx-109797.0.xml",
                    "microsite.wEx-109800.0.xml", "microsite.wEx-109836.0.xml",
                    "microsite.wEx-109909.0.xml", "microsite.wEx-109910.0.xml",
                    "microsite.wEx-109915.0.xml", "microsite.wEx-109986.0.xml",
                    "microsite.wEx-110043.0.xml", "microsite.wEx-110075.0.xml",
                    "microsite.wEx-110172.0.xml", "microsite.wEx-110179.0.xml",
                    "microsite.wEx-110192.0.xml", "microsite.wEx-110258.0.xml",
                    "microsite.wEx-110260.0.xml", "microsite.wEx-110284.0.xml",
                    "microsite.wEx-110287.0.xml", "microsite.wEx-110304.0.xml",
                    "microsite.wEx-110356.0.xml", "microsite.wEx-110358.0.xml",
                    "microsite.wEx-110359.0.xml", "microsite.wEx-110361.0.xml",
                    "microsite.wEx-110362.0.xml", "microsite.wEx-110370.0.xml",
                    "microsite.wEx-110371.0.xml", "microsite.wEx-110400.0.xml",
                    "microsite.wEx-110402.0.xml", "microsite.wEx-110551.0.xml",
                    "microsite.wEx-110590.0.xml", "microsite.wEx-110592.0.xml",
                    "microsite.wEx-110649.0.xml", "microsite.wEx-110718.0.xml",
                    "microsite.wEx-110738.0.xml", "microsite.wEx-110749.0.xml",
                    "microsite.wEx-110768.0.xml", "microsite.wEx-110834.0.xml",
                    "microsite.wEx-110835.0.xml", "microsite.wEx-110860.0.xml",
                    "microsite.wEx-110865.0.xml", "microsite.wEx-110867.0.xml",
                    "microsite.wEx-110879.0.xml", "microsite.wEx-110890.0.xml",
                    "microsite.wEx-110902.0.xml", "microsite.wEx-110915.0.xml",
                    "microsite.wEx-110916.0.xml", "microsite.wEx-111022.0.xml",
                    "microsite.wEx-111040.0.xml", "microsite.wEx-111046.0.xml",
                    "microsite.wEx-111047.0.xml", "microsite.wEx-111048.0.xml",
                    "microsite.wEx-111056.0.xml", "microsite.wEx-111073.0.xml",
                    "microsite.wEx-111130.0.xml", "microsite.wEx-111153.0.xml",
                    "microsite.wEx-111154.0.xml", "microsite.wEx-111167.0.xml",
                    "microsite.wEx-111177.0.xml", "microsite.wEx-111179.0.xml",
                    "microsite.wEx-111180.0.xml", "microsite.wEx-111186.0.xml",
                    "microsite.wEx-111188.0.xml", "microsite.wEx-111194.0.xml",
                    "microsite.wEx-111195.0.xml", "microsite.wEx-111204.0.xml",
                    "microsite.wEx-111211.0.xml", "microsite.wEx-111258.0.xml",
                    "microsite.wEx-111272.0.xml", "microsite.wEx-111273.0.xml",
                    "microsite.wEx-111274.0.xml", "microsite.wEx-111368.0.xml",
                    "microsite.wEx-111372.0.xml", "microsite.wEx-111377.0.xml",
                    "microsite.wEx-111383.0.xml", "microsite.wEx-111448.0.xml",
                    "microsite.wEx-111460.0.xml", "microsite.wEx-111463.0.xml",
                    "microsite.wEx-111466.0.xml", "microsite.wEx-111469.0.xml",
                    "microsite.wEx-111471.0.xml", "microsite.wEx-111480.0.xml",
                    "microsite.wEx-111535.0.xml", "microsite.wEx-111538.0.xml",
                    "microsite.wEx-111567.0.xml", "microsite.wEx-111612.0.xml",
                    "microsite.wEx-111614.0.xml", "microsite.wEx-111696.0.xml",
                    "microsite.wEx-111706.0.xml", "microsite.wEx-111713.0.xml",
                    "microsite.wEx-111727.0.xml", "microsite.wEx-111732.0.xml",
                    "microsite.wEx-111734.0.xml", "microsite.wEx-111736.0.xml",
                    "microsite.wEx-111821.0.xml", "microsite.wEx-111823.0.xml",
                    "microsite.wEx-111891.0.xml", "microsite.wEx-111900.0.xml",
                    "microsite.wEx-111922.0.xml", "microsite.wEx-111938.0.xml",
                    "microsite.wEx-112094.0.xml", "microsite.wEx-112098.0.xml",
                    "microsite.wEx-112108.0.xml", "microsite.wEx-112109.0.xml",
                    "microsite.wEx-112110.0.xml", "microsite.wEx-112149.0.xml",
                    "microsite.wEx-112150.0.xml", "microsite.wEx-112173.0.xml",
                    "microsite.wEx-112197.0.xml", "microsite.wEx-112301.0.xml",
                    "microsite.wEx-112303.0.xml", "microsite.wEx-112304.0.xml",
                    "microsite.wEx-112306.0.xml", "microsite.wEx-112313.0.xml",
                    "microsite.wEx-112333.0.xml", "microsite.wEx-112343.0.xml",
                    "microsite.wEx-112394.0.xml", "microsite.wEx-112395.0.xml",
                    "microsite.wEx-112398.0.xml", "microsite.wEx-112414.0.xml",
                    "microsite.wEx-112418.0.xml", "microsite.wEx-112426.0.xml",
                    "microsite.wEx-112496.0.xml", "microsite.wEx-112498.0.xml",
                    "microsite.wEx-112500.0.xml", "microsite.wEx-112671.0.xml",
                    "microsite.wEx-112674.0.xml", "microsite.wEx-112691.0.xml",
                    "microsite.wEx-112757.0.xml", "microsite.wEx-112785.0.xml",
                    "microsite.wEx-112786.0.xml", "microsite.wEx-112795.0.xml",
                    "microsite.wEx-112796.0.xml", "microsite.wEx-112875.0.xml",
                    "microsite.wEx-112921.0.xml", "microsite.wEx-112960.0.xml",
                    "microsite.wEx-113001.0.xml", "microsite.wEx-113002.0.xml",
                    "microsite.wEx-113003.0.xml", "microsite.wEx-113021.0.xml",
                    "microsite.wEx-113022.0.xml", "microsite.wEx-113029.0.xml",
                    "microsite.wEx-113032.0.xml", "microsite.wEx-113036.0.xml",
                    "microsite.wEx-113038.0.xml", "microsite.wEx-113063.0.xml",
                    "microsite.wEx-113064.0.xml", "microsite.wEx-113131.0.xml",
                    "microsite.wEx-113133.0.xml", "microsite.wEx-113164.0.xml",
                    "microsite.wEx-113167.0.xml", "microsite.wEx-113226.0.xml",
                    "microsite.wEx-113228.0.xml", "microsite.wEx-113232.0.xml",
                    "microsite.wEx-113263.0.xml", "microsite.wEx-113274.0.xml",
                    "microsite.wEx-113275.0.xml", "microsite.wEx-113360.0.xml",
                    "microsite.wEx-113363.0.xml", "microsite.wEx-113367.0.xml",
                    "microsite.wEx-113368.0.xml", "microsite.wEx-113380.0.xml",
                    "microsite.wEx-113384.0.xml", "microsite.wEx-113440.0.xml",
                    "microsite.wEx-113444.0.xml", "microsite.wEx-113498.0.xml",
                    "microsite.wEx-113507.0.xml", "microsite.wEx-113508.0.xml",
                    "microsite.wEx-113512.0.xml", "microsite.wEx-113521.0.xml",
                    "microsite.wEx-113535.0.xml", "microsite.wEx-113616.0.xml",
                    "microsite.wEx-113618.0.xml", "microsite.wEx-113620.0.xml",
                    "microsite.wEx-113638.0.xml", "microsite.wEx-113639.0.xml",
                    "microsite.wEx-113713.0.xml", "microsite.wEx-113724.0.xml",
                    "microsite.wEx-113728.0.xml", "microsite.wEx-113736.0.xml",
                    "microsite.wEx-113737.0.xml", "microsite.wEx-113748.0.xml",
                    "microsite.wEx-113750.0.xml", "microsite.wEx-113893.0.xml",
                    "microsite.wEx-113896.0.xml", "microsite.wEx-113907.0.xml",
                    "microsite.wEx-113922.0.xml", "microsite.wEx-113924.0.xml",
                    "microsite.wEx-113937.0.xml", "microsite.wEx-113965.0.xml",
                    "microsite.wEx-114002.0.xml", "microsite.wEx-114003.0.xml",
                    "microsite.wEx-114009.0.xml", "microsite.wEx-114075.0.xml",
                    "microsite.wEx-114076.0.xml", "microsite.wEx-114079.0.xml",
                    "microsite.wEx-114084.0.xml", "microsite.wEx-114172.0.xml",
                    "microsite.wEx-114218.0.xml", "microsite.wEx-114226.0.xml",
                    "microsite.wEx-114232.0.xml", "microsite.wEx-114234.0.xml",
                    "microsite.wEx-114259.0.xml", "microsite.wEx-114274.0.xml",
                    "microsite.wEx-114295.0.xml", "microsite.wEx-114297.0.xml",
                    "microsite.wEx-114307.0.xml", "microsite.wEx-114309.0.xml",
                    "microsite.wEx-114315.0.xml", "microsite.wEx-114320.0.xml",
                    "microsite.wEx-114326.0.xml", "microsite.wEx-114333.0.xml",
                    "microsite.wEx-114338.0.xml", "microsite.wEx-114351.0.xml",
                    "microsite.wEx-114355.0.xml", "microsite.wEx-114363.0.xml",
                    "microsite.wEx-114365.0.xml", "microsite.wEx-114366.0.xml",
                    "microsite.wEx-114374.0.xml", "microsite.wEx-114378.0.xml",
                    "microsite.wEx-114385.0.xml", "microsite.wEx-114386.0.xml",
                    "microsite.wEx-114387.0.xml", "microsite.wEx-114388.0.xml",
                    "microsite.wEx-114393.0.xml", "microsite.wEx-114395.0.xml",
                    "microsite.wEx-114399.0.xml", "microsite.wEx-114403.0.xml",
                    "microsite.wEx-114410.0.xml", "microsite.wEx-114411.0.xml",
                    "microsite.wEx-114415.0.xml", "microsite.wEx-114418.0.xml",
                    "microsite.wEx-114437.0.xml", "microsite.wEx-114438.0.xml",
                    "microsite.wEx-114441.0.xml", "microsite.wEx-114443.0.xml",
                    "microsite.wEx-114446.0.xml", "microsite.wEx-114453.0.xml",
                    "microsite.wEx-114456.0.xml", "microsite.wEx-114458.0.xml",
                    "microsite.wEx-114460.0.xml", "microsite.wEx-114465.0.xml",
                    "microsite.wEx-114480.0.xml", "microsite.wEx-114481.0.xml",
                    "microsite.wEx-114483.0.xml", "microsite.wEx-114485.0.xml",
                    "microsite.wEx-114486.0.xml", "microsite.wEx-114489.0.xml",
                    "microsite.wEx-114501.0.xml", "microsite.wEx-114502.0.xml",
                    "microsite.wEx-114503.0.xml", "microsite.wEx-114506.0.xml",
                    "microsite.wEx-114507.0.xml", "microsite.wEx-114513.0.xml",
                    "microsite.wEx-114524.0.xml", "microsite.wEx-114526.0.xml",
                    "microsite.wEx-114527.0.xml", "microsite.wEx-114533.0.xml",
                    "microsite.wEx-114552.0.xml", "microsite.wEx-114554.0.xml",
                    "microsite.wEx-114555.0.xml", "microsite.wEx-114557.0.xml",
                    "microsite.wEx-114558.0.xml", "microsite.wEx-114566.0.xml",
                    "microsite.wEx-114568.0.xml", "microsite.wEx-114575.0.xml",
                    "microsite.wEx-114576.0.xml", "microsite.wEx-114591.0.xml",
                    "microsite.wEx-114595.0.xml", "microsite.wEx-114613.0.xml",
                    "microsite.wEx-114619.0.xml", "microsite.wEx-114627.0.xml",
                    "microsite.wEx-114630.0.xml", "microsite.wEx-114639.0.xml",
                    "microsite.wEx-114640.0.xml", "microsite.wEx-114644.0.xml",
                    "microsite.wEx-114646.0.xml", "microsite.wEx-114704.0.xml",
                    "microsite.wEx-114800.0.xml", "microsite.wEx-114813.0.xml",
                    "microsite.wEx-114815.0.xml", "microsite.wEx-114816.0.xml",
                    "microsite.wEx-114834.0.xml", "microsite.wEx-114845.0.xml",
                    "microsite.wEx-114847.0.xml", "microsite.wEx-114873.0.xml",
                    "microsite.wEx-114944.0.xml", "microsite.wEx-114958.0.xml",
                    "microsite.wEx-114963.0.xml", "microsite.wEx-114965.0.xml",
                    "microsite.wEx-114971.0.xml", "microsite.wEx-114984.0.xml",
                    "microsite.wEx-114995.0.xml", "microsite.wEx-114998.0.xml",
                    "microsite.wEx-114999.0.xml", "microsite.wEx-115010.0.xml",
                    "microsite.wEx-115022.0.xml", "microsite.wEx-115032.0.xml",
                    "microsite.wEx-115044.0.xml", "microsite.wEx-115045.0.xml",
                    "microsite.wEx-115108.0.xml", "microsite.wEx-115131.0.xml",
                    "microsite.wEx-115132.0.xml", "microsite.wEx-115135.0.xml",
                    "microsite.wEx-115151.0.xml", "microsite.wEx-115152.0.xml",
                    "microsite.wEx-115154.0.xml", "microsite.wEx-115190.0.xml",
                    "microsite.wEx-115195.0.xml", "microsite.wEx-115215.0.xml",
                    "microsite.wEx-115221.0.xml", "microsite.wEx-115222.0.xml",
                    "microsite.wEx-115226.0.xml", "microsite.wEx-115232.0.xml",
                    "microsite.wEx-115233.0.xml", "microsite.wEx-115234.0.xml",
                    "microsite.wEx-115235.0.xml", "microsite.wEx-115236.0.xml",
                    "microsite.wEx-115251.0.xml", "microsite.wEx-115266.0.xml",
                    "microsite.wEx-115279.0.xml", "microsite.wEx-115283.0.xml",
                    "microsite.wEx-115284.0.xml", "microsite.wEx-115290.0.xml",
                    "microsite.wEx-115292.0.xml", "microsite.wEx-115298.0.xml",
                    "microsite.wEx-115299.0.xml", "microsite.wEx-115300.0.xml",
                    "microsite.wEx-115301.0.xml", "microsite.wEx-115307.0.xml",
                    "microsite.wEx-115309.0.xml", "microsite.wEx-115323.0.xml",
                    "microsite.wEx-115328.0.xml", "microsite.wEx-115334.0.xml",
                    "microsite.wEx-115346.0.xml", "microsite.wEx-115347.0.xml",
                    "microsite.wEx-115349.0.xml", "microsite.wEx-115350.0.xml",
                    "microsite.wEx-115352.0.xml", "microsite.wEx-115354.0.xml",
                    "microsite.wEx-115357.0.xml", "microsite.wEx-115358.0.xml",
                    "microsite.wEx-115360.0.xml", "microsite.wEx-115378.0.xml",
                    "microsite.wEx-115379.0.xml", "microsite.wEx-115383.0.xml",
                    "microsite.wEx-115393.0.xml", "microsite.wEx-115410.0.xml",
                    "microsite.wEx-115414.0.xml", "microsite.wEx-115415.0.xml",
                    "microsite.wEx-115417.0.xml", "microsite.wEx-115419.0.xml",
                    "microsite.wEx-115420.0.xml", "microsite.wEx-115422.0.xml",
                    "microsite.wEx-115423.0.xml", "microsite.wEx-115425.0.xml",
                    "microsite.wEx-115431.0.xml", "microsite.wEx-115452.0.xml",
                    "microsite.wEx-115489.0.xml", "microsite.wEx-115490.0.xml",
                    "microsite.wEx-115491.0.xml", "microsite.wEx-115492.0.xml",
                    "microsite.wEx-115493.0.xml", "microsite.wEx-115495.0.xml",
                    "microsite.wEx-115497.0.xml", "microsite.wEx-115498.0.xml",
                    "microsite.wEx-115513.0.xml", "microsite.wEx-115515.0.xml",
                    "microsite.wEx-115519.0.xml", "microsite.wEx-115520.0.xml",
                    "microsite.wEx-115528.0.xml", "microsite.wEx-115529.0.xml",
                    "microsite.wEx-115535.0.xml", "microsite.wEx-115536.0.xml",
                    "microsite.wEx-115538.0.xml", "microsite.wEx-115540.0.xml",
                    "microsite.wEx-115547.0.xml", "microsite.wEx-115548.0.xml",
                    "microsite.wEx-115549.0.xml", "microsite.wEx-115552.0.xml",
                    "microsite.wEx-115555.0.xml", "microsite.wEx-115557.0.xml",
                    "microsite.wEx-115562.0.xml", "microsite.wEx-115563.0.xml",
                    "microsite.wEx-115566.0.xml", "microsite.wEx-115572.0.xml",
                    "microsite.wEx-115573.0.xml", "microsite.wEx-115574.0.xml",
                    "microsite.wEx-115590.0.xml", "microsite.wEx-115592.0.xml",
                    "microsite.wEx-115593.0.xml", "microsite.wEx-115599.0.xml",
                    "microsite.wEx-115601.0.xml", "microsite.wEx-115606.0.xml",
                    "microsite.wEx-115609.0.xml", "microsite.wEx-115612.0.xml",
                    "microsite.wEx-115616.0.xml", "microsite.wEx-115621.0.xml",
                    "microsite.wEx-115625.0.xml", "microsite.wEx-115631.0.xml",
                    "microsite.wEx-115632.0.xml", "microsite.wEx-115638.0.xml",
                    "microsite.wEx-115639.0.xml", "microsite.wEx-115641.0.xml",
                    "microsite.wEx-115642.0.xml", "microsite.wEx-115652.0.xml",
                    "microsite.wEx-115654.0.xml", "microsite.wEx-115660.0.xml",
                    "microsite.wEx-115661.0.xml", "microsite.wEx-115664.0.xml",
                    "microsite.wEx-115666.0.xml", "microsite.wEx-115667.0.xml",
                    "microsite.wEx-115672.0.xml", "microsite.wEx-115674.0.xml",
                    "microsite.wEx-115675.0.xml", "microsite.wEx-115676.0.xml",
                    "microsite.wEx-115677.0.xml", "microsite.wEx-115680.0.xml",
                    "microsite.wEx-115681.0.xml", "microsite.wEx-115682.0.xml",
                    "microsite.wEx-115687.0.xml", "microsite.wEx-115688.0.xml",
                    "microsite.wEx-115707.0.xml", "microsite.wEx-115708.0.xml",
                    "microsite.wEx-115726.0.xml", "microsite.wEx-115729.0.xml",
                    "microsite.wEx-115730.0.xml", "microsite.wEx-115753.0.xml",
                    "microsite.wEx-115778.0.xml", "microsite.wEx-115780.0.xml",
                    "microsite.wEx-115781.0.xml", "microsite.wEx-115783.0.xml",
                    "microsite.wEx-115784.0.xml", "microsite.wEx-115804.0.xml",
                    "microsite.wEx-115805.0.xml", "microsite.wEx-115806.0.xml",
                    "microsite.wEx-115813.0.xml", "microsite.wEx-115816.0.xml",
                    "microsite.wEx-115817.0.xml", "microsite.wEx-115820.0.xml",
                    "microsite.wEx-115849.0.xml", "microsite.wEx-115850.0.xml",
                    "microsite.wEx-115852.0.xml", "microsite.wEx-115854.0.xml",
                    "microsite.wEx-115856.0.xml", "microsite.wEx-115862.0.xml",
                    "microsite.wEx-115864.0.xml", "microsite.wEx-115869.0.xml",
                    "microsite.wEx-115872.0.xml", "microsite.wEx-115874.0.xml",
                    "microsite.wEx-115880.0.xml", "microsite.wEx-115883.0.xml",
                    "microsite.wEx-115887.0.xml", "microsite.wEx-115890.0.xml",
                    "microsite.wEx-115894.0.xml", "microsite.wEx-115895.0.xml",
                    "microsite.wEx-115899.0.xml", "microsite.wEx-115900.0.xml",
                    "microsite.wEx-115902.0.xml", "microsite.wEx-115903.0.xml",
                    "microsite.wEx-115904.0.xml", "microsite.wEx-115905.0.xml",
                    "microsite.wEx-115907.0.xml", "microsite.wEx-115908.0.xml",
                    "microsite.wEx-115915.0.xml", "microsite.wEx-115916.0.xml",
                    "microsite.wEx-115918.0.xml", "microsite.wEx-115922.0.xml",
                    "microsite.wEx-115923.0.xml", "microsite.wEx-115926.0.xml",
                    "microsite.wEx-115935.0.xml", "microsite.wEx-115937.0.xml",
                    "microsite.wEx-115940.0.xml", "microsite.wEx-115949.0.xml",
                    "microsite.wEx-115962.0.xml", "microsite.wEx-115963.0.xml",
                    "microsite.wEx-115966.0.xml", "microsite.wEx-115967.0.xml",
                    "microsite.wEx-115969.0.xml", "microsite.wEx-115970.0.xml",
                    "microsite.wEx-115971.0.xml", "microsite.wEx-115972.0.xml",
                    "microsite.wEx-115980.0.xml", "microsite.wEx-115981.0.xml",
                    "microsite.wEx-115984.0.xml", "microsite.wEx-115986.0.xml",
                    "microsite.wEx-115987.0.xml", "microsite.wEx-115988.0.xml",
                    "microsite.wEx-115989.0.xml", "microsite.wEx-116020.0.xml",
                    "microsite.wEx-116027.0.xml", "microsite.wEx-116028.0.xml",
                    "microsite.wEx-116029.0.xml", "microsite.wEx-116030.0.xml",
                    "microsite.wEx-116041.0.xml", "microsite.wEx-116046.0.xml",
                    "microsite.wEx-116060.0.xml", "microsite.wEx-116069.0.xml",
                    "microsite.wEx-116070.0.xml", "microsite.wEx-116076.0.xml",
                    "microsite.wEx-116089.0.xml", "microsite.wEx-116090.0.xml",
                    "microsite.wEx-116111.0.xml", "microsite.wEx-116115.0.xml",
                    "microsite.wEx-116118.0.xml", "microsite.wEx-116119.0.xml",
                    "microsite.wEx-116125.0.xml", "microsite.wEx-116128.0.xml",
                    "microsite.wEx-116129.0.xml", "microsite.wEx-116153.0.xml",
                    "microsite.wEx-116161.0.xml", "microsite.wEx-116164.0.xml",
                    "microsite.wEx-116166.0.xml", "microsite.wEx-116199.0.xml",
                    "microsite.wEx-116202.0.xml", "microsite.wEx-116203.0.xml",
                    "microsite.wEx-116208.0.xml", "microsite.wEx-116212.0.xml",
                    "microsite.wEx-116213.0.xml", "microsite.wEx-116214.0.xml",
                    "microsite.wEx-116215.0.xml", "microsite.wEx-116220.0.xml",
                    "microsite.wEx-116222.0.xml", "microsite.wEx-116248.0.xml",
                    "microsite.wEx-116249.0.xml", "microsite.wEx-116250.0.xml",
                    "microsite.wEx-116254.0.xml", "microsite.wEx-116255.0.xml",
                    "microsite.wEx-116256.0.xml", "microsite.wEx-116257.0.xml",
                    "microsite.wEx-116258.0.xml", "microsite.wEx-116259.0.xml",
                    "microsite.wEx-116261.0.xml", "microsite.wEx-116262.0.xml",
                    "microsite.wEx-116263.0.xml", "microsite.wEx-116264.0.xml",
                    "microsite.wEx-116265.0.xml", "microsite.wEx-116266.0.xml",
                    "microsite.wEx-116267.0.xml", "microsite.wEx-116268.0.xml",
                    "microsite.wEx-116269.0.xml", "microsite.wEx-116270.0.xml",
                    "microsite.wEx-116271.0.xml", "microsite.wEx-116272.0.xml",
                    "microsite.wEx-116274.0.xml", "microsite.wEx-116281.0.xml",
                    "microsite.wEx-116282.0.xml", "microsite.wEx-116283.0.xml",
                    "microsite.wEx-116284.0.xml", "microsite.wEx-116285.0.xml",
                    "microsite.wEx-116286.0.xml", "microsite.wEx-116287.0.xml",
                    "microsite.wEx-116297.0.xml", "microsite.wEx-116298.0.xml",
                    "microsite.wEx-116300.0.xml", "microsite.wEx-116302.0.xml",
                    "microsite.wEx-116308.0.xml", "microsite.wEx-116310.0.xml",
                    "microsite.wEx-116315.0.xml", "microsite.wEx-116316.0.xml",
                    "microsite.wEx-116325.0.xml", "microsite.wEx-116332.0.xml",
                    "microsite.wEx-116334.0.xml", "microsite.wEx-116335.0.xml",
                    "microsite.wEx-116336.0.xml", "microsite.wEx-116337.0.xml",
                    "microsite.wEx-116338.0.xml", "microsite.wEx-116340.0.xml",
                    "microsite.wEx-116342.0.xml", "microsite.wEx-116349.0.xml",
                    "microsite.wEx-116359.0.xml", "microsite.wEx-116360.0.xml",
                    "microsite.wEx-116369.0.xml", "microsite.wEx-116407.0.xml",
                    "microsite.wEx-116412.0.xml", "microsite.wEx-116414.0.xml",
                    "microsite.wEx-116420.0.xml", "microsite.wEx-116421.0.xml",
                    "microsite.wEx-116425.0.xml", "microsite.wEx-116427.0.xml",
                    "microsite.wEx-116432.0.xml", "microsite.wEx-116433.0.xml",
                    "microsite.wEx-116435.0.xml", "microsite.wEx-116436.0.xml",
                    "microsite.wEx-116439.0.xml", "microsite.wEx-116444.0.xml",
                    "microsite.wEx-116445.0.xml", "microsite.wEx-116446.0.xml",
                    "microsite.wEx-116447.0.xml", "microsite.wEx-116448.0.xml",
                    "microsite.wEx-116449.0.xml", "microsite.wEx-116450.0.xml",
                    "microsite.wEx-116451.0.xml", "microsite.wEx-116464.0.xml",
                    "microsite.wEx-116475.0.xml", "microsite.wEx-116480.0.xml",
                    "microsite.wEx-116483.0.xml", "microsite.wEx-116486.0.xml",
                    "microsite.wEx-116487.0.xml", "microsite.wEx-116488.0.xml",
                    "microsite.wEx-116492.0.xml", "microsite.wEx-116530.0.xml",
                    "microsite.wEx-116534.0.xml", "microsite.wEx-116544.0.xml",
                    "microsite.wEx-116550.0.xml", "microsite.wEx-116553.0.xml",
                    "microsite.wEx-116554.0.xml", "microsite.wEx-116564.0.xml",
                    "microsite.wEx-116569.0.xml", "microsite.wEx-116574.0.xml",
                    "microsite.wEx-116577.0.xml", "microsite.wEx-116580.0.xml",
                    "microsite.wEx-116583.0.xml", "microsite.wEx-116585.0.xml",
                    "microsite.wEx-116591.0.xml", "microsite.wEx-116592.0.xml",
                    "microsite.wEx-116593.0.xml", "microsite.wEx-116597.0.xml",
                    "microsite.wEx-116603.0.xml", "microsite.wEx-116607.0.xml",
                    "microsite.wEx-116617.0.xml", "microsite.wEx-116632.0.xml",
                    "microsite.wEx-116634.0.xml", "microsite.wEx-116636.0.xml",
                    "microsite.wEx-116637.0.xml", "microsite.wEx-116638.0.xml",
                    "microsite.wEx-116639.0.xml", "microsite.wEx-116641.0.xml",
                    "microsite.wEx-116646.0.xml", "microsite.wEx-116648.0.xml",
                    "microsite.wEx-116680.0.xml", "microsite.wEx-116681.0.xml",
                    "microsite.wEx-116684.0.xml", "microsite.wEx-116685.0.xml",
                    "microsite.wEx-116687.0.xml", "microsite.wEx-116694.0.xml",
                    "microsite.wEx-116695.0.xml", "microsite.wEx-116697.0.xml",
                    "microsite.wEx-116701.0.xml", "microsite.wEx-116715.0.xml",
                    "microsite.wEx-116716.0.xml", "microsite.wEx-116719.0.xml",
                    "microsite.wEx-116722.0.xml", "microsite.wEx-116727.0.xml",
                    "microsite.wEx-116728.0.xml", "microsite.wEx-116733.0.xml",
                    "microsite.wEx-116737.0.xml", "microsite.wEx-116739.0.xml",
                    "microsite.wEx-116741.0.xml", "microsite.wEx-116746.0.xml",
                    "microsite.wEx-116748.0.xml", "microsite.wEx-116749.0.xml",
                    "microsite.wEx-116751.0.xml", "microsite.wEx-116755.0.xml",
                    "microsite.wEx-116756.0.xml", "microsite.wEx-116762.0.xml",
                    "microsite.wEx-116764.0.xml", "microsite.wEx-116765.0.xml",
                    "microsite.wEx-116768.0.xml", "microsite.wEx-116771.0.xml",
                    "microsite.wEx-116780.0.xml", "microsite.wEx-116788.0.xml",
                    "microsite.wEx-116807.0.xml", "microsite.wEx-116824.0.xml",
                    "microsite.wEx-116827.0.xml", "microsite.wEx-116828.0.xml",
                    "microsite.wEx-116829.0.xml", "microsite.wEx-116831.0.xml",
                    "microsite.wEx-116832.0.xml", "microsite.wEx-116836.0.xml",
                    "microsite.wEx-116837.0.xml", "microsite.wEx-116838.0.xml",
                    "microsite.wEx-116839.0.xml", "microsite.wEx-116840.0.xml",
                    "microsite.wEx-116841.0.xml", "microsite.wEx-116842.0.xml",
                    "microsite.wEx-116843.0.xml", "microsite.wEx-116844.0.xml",
                    "microsite.wEx-116847.0.xml", "microsite.wEx-116849.0.xml",
                    "microsite.wEx-116850.0.xml", "microsite.wEx-116851.0.xml",
                    "microsite.wEx-116852.0.xml", "microsite.wEx-116854.0.xml",
                    "microsite.wEx-116855.0.xml", "microsite.wEx-116860.0.xml",
                    "microsite.wEx-116866.0.xml", "microsite.wEx-116918.0.xml",
                    "microsite.wEx-116923.0.xml", "microsite.wEx-116924.0.xml",
                    "microsite.wEx-116929.0.xml", "microsite.wEx-116932.0.xml",
                    "microsite.wEx-116934.0.xml", "microsite.wEx-116935.0.xml",
                    "microsite.wEx-116941.0.xml", "microsite.wEx-116942.0.xml",
                    "microsite.wEx-116946.0.xml", "microsite.wEx-116948.0.xml",
                    "microsite.wEx-116950.0.xml", "microsite.wEx-116951.0.xml",
                    "microsite.wEx-116952.0.xml", "microsite.wEx-116955.0.xml",
                    "microsite.wEx-116963.0.xml", "microsite.wEx-116972.0.xml",
                    "microsite.wEx-116983.0.xml", "microsite.wEx-117001.0.xml",
                    "microsite.wEx-117012.0.xml", "microsite.wEx-117013.0.xml",
                    "microsite.wEx-117016.0.xml", "microsite.wEx-117017.0.xml",
                    "microsite.wEx-117019.0.xml", "microsite.wEx-117021.0.xml",
                    "microsite.wEx-117024.0.xml", "microsite.wEx-117026.0.xml",
                    "microsite.wEx-117038.0.xml", "microsite.wEx-117039.0.xml",
                    "microsite.wEx-117043.0.xml", "microsite.wEx-117044.0.xml",
                    "microsite.wEx-117046.0.xml"
                };




            Console.Write("Option:");
            string option = Console.ReadLine();
            if (option.Equals("1"))
            {
                string path = @"C:\inetpub\integratorxmlfiles\uploaded\archives\microsite";
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();

                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    if (filesMicrosite.Any(d => f.Name.Contains(d)))
                    {
                        string[] newname = Regex.Split(f.Name, "microsite");
                        f.CopyTo(
                            string.Format("C:/inetpub/integratorxmlfiles/uploaded/archives/microsite{0}", newname[1]),
                            true);
                        Console.WriteLine(newname[1]);
                    }
                }
            }
            else if (option.Equals("2"))
            {
                string path = @"C:\inetpub\integratorxmlfiles\uploaded\archives\profile";
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();

                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    try
                    {
                        string[] newname = Regex.Split(f.Name, "fan");
                        f.CopyTo(string.Format("c:/inetpub/integratorxmlfiles/uploaded/profiles/fan{0}", newname[1]), true);
                        Console.WriteLine(newname[1]);

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("couldn't copy {0}", f.Name);
                    }

                }
            }

            else if (option.Equals("3"))
            {
                //FanoramaStagingEntities entity = new FanoramaStagingEntities();
                //foreach (User user in entity.Users)
                //{
                //    if (!IsValid(user.Email) )
                //    {
                //        BadUser baduser = new BadUser();

                //        entity.BadUsers.AddObject(baduser);
                //    }
                //}
            }
            else if (option.Equals("4"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                string pricelist = ConfigurationManager.AppSettings["duplicatedPricelist"].ToString();
                var duplicates = (from d in entity.UserProfiles where d.PropertyDefinitionID == 69 && d.PropertyValue.Equals(pricelist) select d).DefaultIfEmpty();
                var duplicateTable = (from dc in duplicates
                                      group dc by dc.UserID into g
                                      let c = g.Count()
                                      where c > 1
                                      select new { g.Key, c }).DefaultIfEmpty();
                foreach (var dup in duplicateTable)
                {
                    if (dup != null)
                    {
                        //find the userid inside duplicates
                        var repeated = from d in duplicates where dup.Key == d.UserID select d;
                        int counter = 0;
                        // loop through all of them 
                        if (repeated != null)
                        {
                            foreach (var rep in repeated)
                            {
                                if (rep != null && counter > 0)
                                {
                                    entity.UserProfiles.Remove(rep);
                                    Console.WriteLine(rep.UserID);
                                }
                                counter++;

                            }
                        }
                    }
                }
                entity.SaveChanges();
            }
            else if (option.Equals("5"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                string path = string.Format(@"c:\kianoush\profile\");
                string fullpath;
                List<string> result = new List<string>();
                List<string> profileFiles = listAllFiles(path);
                foreach (string profileFile in profileFiles)
                {

                    fullpath = string.Format("{0}{1}", path, profileFile);
                    try
                    {
                        if (System.IO.File.Exists(fullpath))
                        {
                            using (XmlTextReader xmlreader = new XmlTextReader(fullpath))
                            {

                                InsertIntoDB(xmlreader, entity);
                            }
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0} hasn't been uploaded", profileFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (option.Equals("6"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                var createdmicrosites = from m in entity.TAA_Microsite where m.IntegratorRetrievalCode != null select m;
                foreach (var microsite in createdmicrosites)
                {
                    TAA_FanID newfan = new TAA_FanID();
                    newfan.Accent = microsite.Accent;
                    newfan.PrimaryColor = microsite.PrimaryColour;
                    newfan.SecondaryColor = microsite.SecondaryColour;
                    newfan.City = microsite.City;
                    newfan.TeamName = microsite.TeamName;
                    newfan.CreatedByUserID = -1;
                    newfan.CreatedOnDate = DateTime.Now;
                    newfan.Deleted = false;
                    newfan.School = microsite.School;
                    newfan.City = microsite.City;
                    newfan.DesignName = microsite.TeamName;
                    newfan.MicrositeID = microsite.MicrositeID;
                    newfan.PrimaryColorID = microsite.PrimaryColorID;
                    newfan.SecondaryColorID = microsite.SecondaryColorID;
                    newfan.AccentColorID = microsite.AccentColorID;
                    int sportid = -1;

                    if (microsite.SportID == null)
                        sportid = -1;
                    else
                        sportid = (int)microsite.SportID;
                    newfan.TAASportID = sportid;
                    string sport;
                    sport = newfan.Sport;
                    if (newfan.Sport == null)
                        sport = "-1";
                    newfan.Sport = sport;
                    entity.TAA_FanID.Add(newfan);

                }
                entity.SaveChanges();
            }
            else if (option.Equals("7"))
            {
                string path = string.Format(@"d:\kianoush\dealers\dealer.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Table));
                StreamReader reader = new StreamReader(path);
                Table dealers = (Table)serializer.Deserialize(reader);
                reader.Close();
                string customerid;
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                StreamWriter writer = new StreamWriter(@"d:\kianoush\dealers\notimported.csv");
                foreach (var dealer in dealers.Items)
                {
                    customerid = dealer.Cell[0].Data.Trim();
                    var userprofile = (from f in entity.UserProfiles where f.PropertyValue.Trim().Equals(customerid) select f).FirstOrDefault();
                    if (userprofile != null)
                    {
                        UserProfile newuserprofile = new UserProfile();
                        newuserprofile.UserID = userprofile.UserID;
                        newuserprofile.Visibility = 2;
                        newuserprofile.PropertyDefinitionID = 68;
                        newuserprofile.PropertyValue = "True";
                        newuserprofile.LastUpdatedDate = DateTime.Now;
                        entity.UserProfiles.Add(newuserprofile);

                        newuserprofile = new UserProfile();

                        newuserprofile.UserID = userprofile.UserID;
                        newuserprofile.Visibility = 2;
                        newuserprofile.PropertyDefinitionID = 67;
                        newuserprofile.PropertyValue = dealer.Cell[4].Data;
                        newuserprofile.LastUpdatedDate = DateTime.Now;
                        entity.UserProfiles.Add(newuserprofile);
                        Console.WriteLine(customerid);

                    }
                    else
                    {

                        writer.WriteLine(customerid);
                    }

                }
                writer.Close();
                entity.SaveChanges();
            }
            else if (option.Equals("8"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                string path = string.Format(@"c:\kianoush\microsite\");
                var players = from p in entity.TAA_RoleCards select p;
                string fullpath;
                List<string> result = new List<string>();
                List<string> profileFiles = listAllFiles(path);
                foreach (string profileFile in profileFiles)
                {

                    fullpath = string.Format("{0}{1}", path, profileFile);
                    try
                    {
                        if (System.IO.File.Exists(fullpath))
                        {
                            using (XmlTextReader xmlreader = new XmlTextReader(fullpath))
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0} hasn't been uploaded", profileFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (option.Equals("9"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                DateTime yesterday = DateTime.Now.AddDays(-2);
                InsertNewProduct(entity, yesterday, "D0008", 13);
                InsertNewProduct(entity, yesterday, "D0010", 8);
                InsertNewProduct(entity, yesterday, "D0012", 2);


            }
            else if (option.Equals("10"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();

                foreach (var microsite in entity.TAA_Microsite)
                {
                    if (microsite.URL != null)
                        if (microsite.URL.Contains("thefanorama.com"))
                        {
                            //string temp = microsite.URL.Replace("slp.", string.Empty);
                            //if (microsite.URL.Contains("blondgorilla"))
                            //    temp = temp.Replace("blondgorilla.", string.Empty);4
                            string temp = microsite.URL.Replace("thefanorama.com", "dev.thefanorama.blondgorilla.com");
                            microsite.URL = temp;
                            Console.WriteLine(temp);
                        }
                }
                entity.SaveChanges();

            }
            else if (option.Equals("11"))
            {
                FanoramaStagingEntities entity = new FanoramaStagingEntities();
                var microsites = entity.TAA_Microsite.Where(p => p.CreatedFromSLP == false).DefaultIfEmpty();
                string path = string.Empty;
                string target = string.Empty;
                string fileName = string.Empty;
                string fileExtention = string.Empty;

                foreach (var microsite in microsites)
                {
                    string mainpath = @"c:/temp/microimages/";
                    path = string.Format(@"{0}MicrositeImages/{1}/", mainpath, microsite.MicrositeID);

                    var fanid = entity.TAA_FanID.Where(p => p.MicrositeID == microsite.MicrositeID).FirstOrDefault();

                    fileName = Guid.NewGuid().ToString();
                    var micrositeId=microsite.MicrositeID;
                    var firstOrDefault = integratorEntity.ImageUpdates.FirstOrDefault(i => i.MicrositeId == micrositeId);
                    if (firstOrDefault != null)
                    {
                        string oldpath =firstOrDefault.ImagePath;
                        fileExtention = Path.GetExtension(oldpath);
                        string targetBasePath = string.Format(@"{0}/FanIdImages/{1}/", mainpath, fanid.FanID);
                        if (!Directory.Exists(targetBasePath))
                            Directory.CreateDirectory(targetBasePath);
                        target = string.Format(@"{0}/FanIdImages/{1}/{2}{3}", mainpath, fanid.FanID, fileName, fileExtention);
                        System.IO.File.Copy(oldpath, target, true);
                        fanid.UserUploadedGraphic = target.Replace(mainpath, "http://staging.thefanorama.blondgorilla.com");
                        target = string.Format(@"{0}/FanIdImages/{1}/{2}.tif", mainpath, fanid.FanID, fileName);
                        if (!System.IO.File.Exists(target))
                            System.IO.File.Copy(oldpath, target);
                    }
                    fanid.GAUploadedGraphic = target.Replace(mainpath, "http://staging.thefanorama.blondgorilla.com");
                    Console.WriteLine(target);


                }
                entity.SaveChanges();



            }
            else if (option.Equals("12"))
            {
                var webClient = new WebClient();

                var fanImagesPath = @"D:\inetpub\wwwroot\FanoramaStaging\MicrositeImages\";
                //var fanImagesPath = @"C:\temp\MicrositeImages\";
                var filepath = string.Empty;
                var sceneSevenUrl = "http://216.23.175.26/is/image/TeamworkAthletic/customerUploads/";
                string sceneFilePath;
                var microsites = entity.TAA_Microsite.Where(p => p.CreatedFromSLP == false).DefaultIfEmpty();

                foreach (var microsite in microsites)
                {
                    if (!string.IsNullOrEmpty(microsite.TeamLogo))
                    {
                        if (microsite.MicrositeID == 15114)
                            filepath = filepath;
                        filepath = string.Format("{0}{1}", fanImagesPath, microsite.MicrositeID);
                        if (!Directory.Exists(filepath))
                        {
                            Directory.CreateDirectory(filepath);
                        }
                        sceneFilePath = string.Format("{0}{1}?fmt=tif-alpha", sceneSevenUrl, ConvertExtensionToTif(microsite.TeamLogo));
                        SaveLogo(sceneFilePath, microsite, fanImagesPath);
                    }
                }
                entity.SaveChanges();
            }

            else if (option.Equals("13"))
            {
                var fans = entity.TAA_FanID.Where(e => e.UserUploadedGraphic.Contains("dev."));
                foreach (var fan in fans)
                {
                    fan.UserUploadedGraphic = fan.UserUploadedGraphic.Replace(
                        "http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                    fan.GAUploadedGraphic = fan.GAUploadedGraphic.Replace("http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                }

                entity.SaveChanges();
            }


            else if (option.Equals("13"))
            {
                var fans = entity.TAA_FanID.Where(e => e.UserUploadedGraphic.Contains("dev."));
                foreach (var fan in fans)
                {
                    fan.UserUploadedGraphic = fan.UserUploadedGraphic.Replace(
                        "http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                    fan.GAUploadedGraphic = fan.GAUploadedGraphic.Replace("http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                }

                entity.SaveChanges();
            }

            else if (option.Equals("14"))
            {
                InsertSize("D0011", 1100);
                InsertSize("D0012", 1100);
                InsertSize("D0009", 1100);

                InsertSize("D0011", 1090);
                InsertSize("D0012", 1090);
                InsertSize("D0009", 1090);


                entity.SaveChanges();
            }

            //else if (option.Equals("9"))
            //{
            //    NewTweaker.dnnolddescriptionEntities oldentities = new NewTweaker.dnnolddescriptionEntities();
            //    FanoramaStagingEntities newentity = new FanoramaStagingEntities();
            //    string temp;
            //    foreach (NewTweaker.CAT_Products oldproduct in oldentities.CAT_Products)
            //    {                    
            //        var newproduct = newentity.CAT_Products.Where(o => o.ProductID.Equals(oldproduct.ProductID)).FirstOrDefault();
            //       temp = newproduct.Free1;
            //        if(newproduct!=null)
            //        {
            //            newproduct.Free1 = oldproduct.Free1;
            //            newproduct.Free2 = oldproduct.Free2;
            //            newproduct.Free3 = oldproduct.Free3;
            //        }
            //        Console.WriteLine(string.Format("Product number {0} has been changed description1 {1} to {2}",newproduct.ProductID,temp, newproduct.Free1));
            //    }
            //    newentity.AcceptAllChanges();
            //    newentity.SaveChanges();
            //}
            //else if (option.Equals("9"))
            //{
            //    FanoramaStagingEntities entity = new FanoramaStagingEntities();
            //    var products = from c in entity.CAT_Products where c.CMSProductID>193 && c.ProductName.Contains("Youth") select c;
            //    foreach (var product in products)
            //    {
            //        CAT_AdvCatProducts adv = new CAT_AdvCatProducts();
            //        adv.ProductID = product.ProductID;
            //        adv.AdvCatID = 12;
            //        entity.CAT_AdvCatProducts.AddObject(adv);
            //    }
            //    entity.SaveChanges();
            //}
            //else if (option.Equals("10"))
            //{
            //    FanoramaStagingEntities entity = new FanoramaStagingEntities();
            //    var products = from c in entity.CAT_Products where c.CMSProductID > 193 && c.ProductName.Contains("Adult") select c;
            //    foreach (var product in products)
            //    {
            //        CAT_AdvCatProducts adv = new CAT_AdvCatProducts();
            //        adv.ProductID = product.ProductID;
            //        adv.AdvCatID = 0;
            //        entity.CAT_AdvCatProducts.AddObject(adv);
            //    }
            //    entity.SaveChanges();
            //}
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void InsertSize(string style, int sizeId)
        {
            var products = entity.CAT_Products.Where(e => e.EAN.Contains(style));

            foreach (var catProduct in products)
            {
                if (!entity.TAA_ProductSizes.Any(p => p.ProductID == catProduct.ProductID && p.SizeID == sizeId))
                {
                    var productSize = new TAA_ProductSizes { ProductID = catProduct.ProductID, SizeID = sizeId };
                    entity.TAA_ProductSizes.Add(productSize);
                }
            }
        }

        private static void SaveLogo(string sceneServerImage, TAA_Microsite taamicrosite, string logRootPath)
        {
            string filepath = string.Empty;
            try
            {
                var newguid = Guid.NewGuid(); // Microsite is not created so make sure Image filenames are unique
                var fileName = Path.GetFileName(sceneServerImage);

                var newPath = Path.Combine(logRootPath, taamicrosite.MicrositeID.ToString());
                if (!Directory.Exists(newPath))
                    Directory.CreateDirectory(newPath);
                var webClient = new WebClient();

                if (fileName != null)
                {
                    filepath = string.Format("{0}/{1}~!~{2}", newPath, newguid.ToString(), fileName.Replace("?fmt=tif-alpha", string.Empty));
                    bool isAccessible = IsImageFileAccessible(sceneServerImage, filepath);
                    if (isAccessible)
                    {
                        var liquidPixelDownload =
                            string.Format(
                                "http://teamwork.liquifire.com/teamwork?set=imageurl[{0}]%26call=url[file://microsite/uploadchain.chain]%26sink=format[tif]",
                                sceneServerImage);
                        webClient.DownloadFile(liquidPixelDownload, filepath);
                    }

                    var image = Image.FromFile(filepath);
                    var header = ImageManipulation.ResizeImage(image, new Size(310, 60)); // site header
                    var thumb = ImageManipulation.ResizeImage(image, new Size(82, 64));
                    // thumb for microsite search results

                    // using ~!~ as delimiter so later we can extract the original filename
                    header.Save(newPath + "/header.jpg"); // Microsite Header
                    thumb.Save(newPath + "/thumb.jpg"); // Thumbnail used in Search results

                    image.Dispose();
                    header.Dispose();
                    thumb.Dispose();
                    integratorEntity.InsertImageUpdate(filepath, taamicrosite.MicrositeID);
                    
                }
             

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} == {1} =={2}", taamicrosite.MicrositeID,sceneServerImage ,ex.Message);
            }
        }

        private static bool IsImageFileAccessible(string sceneUrl, string filePath)
        {
            try
            {
                var webClient = new WebClient();
                webClient.DownloadFile(sceneUrl, filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private static void InsertNewProduct(FanoramaStagingEntities entity, DateTime yesterday, string stylenumber, int category)
        {
            var styleProducts = from f in entity.CAT_Products where f.EAN.Contains(stylenumber) && f.PublicationStart > yesterday select f;
            foreach (var styleProduct in styleProducts)
            {
                if (entity.CAT_AdvCatProducts.Any(d => d.CAT_Products.ProductID != styleProduct.ProductID))
                {
                    CAT_AdvCatProducts catproduct = new CAT_AdvCatProducts();
                    catproduct.AdvCatID = category;
                    catproduct.CAT_Products = styleProduct;
                    entity.CAT_AdvCatProducts.Add(catproduct);
                    Console.WriteLine(styleProduct.ProductID);
                }
            }

            entity.SaveChanges();
        }

        /// <summary>
        /// The convert extention to tif.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private static string ConvertExtensionToTif(string url)
        {
            var extension = Path.GetExtension(url);
            if (extension != null && !extension.Contains("tif"))
            {
                url = Path.ChangeExtension(url, "tif");
            }

            return url;
        }

        /// <summary>
        /// Very simple way to check whether the email address is correct or not
        /// </summary>
        /// <param name="emailaddress">The email address of the dealer in string fromat</param>
        /// <returns>It will return false if the email is not valid otherwise it will be true</returns>
        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private static int findLargestFile(List<string> files, string path)
        {

            long max = 0;
            int index = 0;
            int cnt = 0;
            string temp;
            foreach (string file in files
                )
            {
                temp = string.Format("{0}{1}", path, file);

                FileInfo f = new FileInfo(temp);
                if (f.Length > max)
                {
                    max = f.Length;
                    index = cnt;
                }
                cnt++;
            }
            return index;
        }
        public static bool InsertIntoDB(XmlTextReader xml, FanoramaStagingEntities entity)
        {
            bool insideOrganization = false;
            bool insideShippingAddress = false;
            bool insidePaymentType = false;
            bool insideBillingAddress = false;
            bool insideExtensions = false;
            bool insideDefaultMailingAddress = false;
            bool insideUsers = false;
            bool insidePyamentType = false;
            bool isDefault = false;
            User newdealer = new User();
            string paymentTerms = string.Empty;
            int userid = 0;
            bool net30 = false;
            UserProfile dealerprofile = new UserProfile();
            string pricelist = string.Empty;
            string nodeName = string.Empty;
            try
            {
                while (xml.Read())
                {

                    switch (xml.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (xml.Name.Equals("organization"))
                            {
                                insideOrganization = true;
                                newdealer = new User();
                                newdealer.IsSuperUser = false;
                            }
                            else if (xml.Name.Equals("users"))
                                insideUsers = true;
                            else if (xml.Name.Equals("shippingAddress"))
                                insideShippingAddress = true;
                            else if (xml.Name.Equals("paymentType"))
                                insidePyamentType = true;
                            else if (xml.Name.Equals("extensions"))
                                insideExtensions = true;
                            else
                                nodeName = xml.Name;
                            break;
                        case XmlNodeType.Text: //Display the text in each element.                        
                            if (nodeName.Equals("name"))
                            {
                                if (xml.Value != null && xml.Value.Contains("Charmaine"))
                                    newdealer.FirstName = xml.Value;
                                newdealer.DisplayName = xml.Value;

                            }
                            else if (nodeName.Equals("description"))
                            {
                                newdealer.LastName = xml.Value;
                            }
                            else if (insideShippingAddress)
                            {
                                if (nodeName.Equals("default") && xml.Value.Equals("true"))
                                {
                                    isDefault = true;
                                }
                                else if (isDefault)
                                {
                                }
                            }
                            else if (insideExtensions && !insideShippingAddress && !insideUsers && !insidePyamentType)
                            {

                                if (nodeName.Equals("taaAccountId") && xml.Value.Trim().Contains("162859"))
                                {



                                }
                                if (nodeName.Equals("priceList"))
                                {

                                    pricelist = xml.Value;

                                }
                                else if (nodeName.Equals("residential"))
                                {



                                }
                                else if (nodeName.Equals("country"))
                                {



                                }
                                else if (nodeName.Equals("email"))
                                {
                                    if (xml.Value.Contains("jbond@omegasports.net"))
                                        newdealer.Email = xml.Value;
                                    newdealer.Email = xml.Value;
                                    newdealer.Username = xml.Value;

                                }
                                else if (nodeName.Equals("paymentTerm"))
                                {
                                    paymentTerms = xml.Value;
                                    if (paymentTerms.Contains("NET30")) net30 = true;

                                }

                            }
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            if (xml.Name.Equals("organization"))
                            {

                                if (newdealer.Email != null && newdealer.FirstName != null && newdealer.LastName != null && IsValid(newdealer.Email))
                                {

                                    var user = (from u in entity.Users where u.Email.Equals(newdealer.Email) select u).FirstOrDefault();

                                    if (user != null)
                                    {
                                        /// password format is 2 from existing users
                                        Console.WriteLine(user.UserID);
                                        //lovely changes from teamwork
                                        if (pricelist.ToLower().Equals("dealer"))
                                            pricelist = "Regular";
                                        UserProfile userprofile = (from u in entity.UserProfiles where u.UserID == user.UserID && u.PropertyDefinitionID == 69 select u).FirstOrDefault();

                                        if (userprofile != null)
                                        {
                                            userprofile.PropertyValue = pricelist;
                                        }
                                        else
                                        {
                                            userprofile = new UserProfile();
                                            userprofile.UserID = user.UserID;
                                            userprofile.PropertyDefinitionID = 69;
                                            userprofile.Visibility = 2;
                                            user.LastModifiedOnDate = DateTime.Now;
                                            userprofile.PropertyValue = pricelist;
                                            entity.UserProfiles.Add(userprofile);
                                        }
                                        // entity.SaveChanges();

                                    }


                                }

                            }
                            else if (xml.Name.Equals("shippingAddress"))
                                insideShippingAddress = false;
                            else if (xml.Name.Equals("paymentType"))
                                insidePyamentType = false;
                            else if (xml.Name.Equals("extensions"))
                                insideExtensions = false;
                            else if (xml.Name.Equals("users"))
                                insideUsers = false;

                            break;

                    }
                }
                return true;
            }
            catch (XmlException exception)
            {
                Console.WriteLine(exception.Message);

                return false;
            }
        }
        /// <summary>
        /// List all files inside a folder
        /// </summary>
        /// <param name="path">a path that files need to be parsed</param>
        /// <returns>a list of files need to be parsed</returns>
        private static List<string> listAllFiles(string path)
        {
            List<string> files = new List<string>();
            if (Directory.Exists(path))
            {

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();
                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    files.Add(f.Name);
                }
            }
            return files;
        }

    }
}
