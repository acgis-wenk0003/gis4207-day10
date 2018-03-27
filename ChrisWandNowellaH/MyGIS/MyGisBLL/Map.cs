using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGisBLL
{
    public class Map
    {
        private Layer[] _layers = new Layer[0];
        public int LayerCount {
            get { return _layerCount; }
            }
        private int _layerCount;
        public string Name
        {
            get; set;
        }
        private Layer[] Layers
        {
            get { return _layers; }
        }
        public void AddLayer (Layer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layerCount += 1;
            _layers[_layers.Length-1]= layer;
        }
        public Layer GetLayerByName(string LayerName)
        {
            Layer output;
            foreach (Layer ALayer in _layers)
            {

                if (ALayer.Name.Equals(LayerName))
                {
                   output= ALayer;
                    return output;
                                                     
                } 
                if (!ALayer.Name.Equals(LayerName) & !_layers[_layers.Length].Name.Equals(LayerName))
                {
                    output= null;
                    return null;
                }
                else { continue; }

            }
            return null;
        }

    }
}
