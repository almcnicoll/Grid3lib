using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    public class ScanBlockAudioDescription
    {
        public int ID { get; set; }
        public string AudioDescription { get; set; }
        
        public ScanBlockAudioDescription()
        {

        }

        public ScanBlockAudioDescription(int id, string audioDescription)
        {
            ID = id;
            AudioDescription = audioDescription;
        }

        public ScanBlockAudioDescription(ImportClasses.GridScanBlockAudioDescription gridScanBlockAudioDescription)
        {
            ID = gridScanBlockAudioDescription.ScanBlock;
            AudioDescription = gridScanBlockAudioDescription.AudioDescription;
        }
    }
}
