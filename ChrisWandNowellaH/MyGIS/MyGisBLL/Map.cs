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
        private string _name;
        public int LayerCount {
            get { return _layerCount; }
            set { _layerCount = _layers.Length; }
        }
        private int _layerCount;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Layer[] Layers
        {
            get { return _layers; }
        }
        public void AddLayer(Layer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layerCount += 1;
            _layers[_layers.Length - 1] = layer;
        }
        public Layer GetLayerByName(string LayerName)
        {
            Layer output;
            int indexcount=0;
            foreach (Layer ALayer in _layers)
            {

                if (ALayer.Name.Equals(LayerName))
                {
                    output = ALayer;
                    return output;

                }
                if (!ALayer.Name.Equals(LayerName) & _layers.Length.Equals(indexcount))
                {
                    output = null;
                    return null;
                }
                else {
                    indexcount += 1;
                    continue;
                }

            }
            return null;
        }
        public void RemoveLayer(int layerIndex)
        {
            int removeIndex = Array.IndexOf(_layers, layerIndex - 1);
            List<Layer> new_layers = _layers.OfType<Layer>().ToList();
            List<Layer> outputLayers= new List<Layer>();
            if (removeIndex <= LayerCount - 1)
            {
                int indexcount = 0;
                foreach (Layer lLayer in new_layers)
                {
                    if (indexcount == removeIndex)
                    {
                        indexcount += 1;
                        
                    }
                    else {
                        indexcount += 1;
                        outputLayers.Add(lLayer);
                        }
                }
            }
            _layers = outputLayers.ToArray<Layer>();
            Array.Resize(ref _layers, _layers.Length-2);
        }
    }
    
}

