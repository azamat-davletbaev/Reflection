using Newtonsoft.Json;
using System.Diagnostics;

namespace ReflectionApp
{
    internal class MyTimer
    {
        public int Count = 100_000;
        private Stopwatch sw = new Stopwatch();

        /// <summary>
        /// замер кастомного класса
        /// </summary>
        /// <returns></returns>
        public long GetSerializatorTime()
        {
            sw.Stop();

            var f = new F();
            f = f.Get();

            sw.Start();

            for (int i = 0; i < Count; i++)
            {
                string s = f.Serialize();
                var ff = s.DeSerializeF();
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        /// <summary>
        /// замер сериалиции через Newtonsoft.Json 13.0.3
        /// </summary>
        /// <returns></returns>
        public long GetJsonSerilizeTime()
        {
            sw.Stop();                        
            
            var f = new F();
            f = f.Get();

            sw.Start();

            for (int i = 0; i < Count; i++)
            {
                string s = JsonConvert.SerializeObject(f);
                var ff = JsonConvert.DeserializeObject<F>(s);
            }

            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
