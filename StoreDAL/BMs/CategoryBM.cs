using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.BMs
{
    public interface IFigure
    {
        IFigure Clone();
    }

    public class CategoryBM : IFigure
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }
    }


}
