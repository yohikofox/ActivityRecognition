using Microsoft.Spark.CSharp.Core;

namespace ActivityRecognition.Spark
{
    public class SparkWrapper
    {
        private SparkContext SparkContext { get; set; }

        public void InitializeContext()
        {
            var conf = new SparkConf();
            conf.SetAppName("Activity recognition");
        }
    }
}
