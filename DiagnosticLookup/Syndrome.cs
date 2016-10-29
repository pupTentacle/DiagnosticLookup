using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticLookup
{
    public enum poopStructure
    {
        Soft,
        Hard,
        Spread,
        Solid,
        Sticky,
        Other
    }

    public enum poopSymptoms
    {
        Burning,
        StrongSmell,
        Gas,
        Bleeding,
        Other
    }

    public enum feelingAfterPoop
    {
        Lighter,
        Heavier,
        Other
    }

    public enum generalDigestiveSymptoms
    {
        Appetite,
        Gas,
        NauseaOrVomiting,
        Diarrhea,
        Constipation,
        Heartburn,
        Aftah,
        Hiccups,
        StomachPressureAndPain,
        FullStomach,
        Hernia,
        Hemmeroids,
        Bleeding,
        Borborigmus,
        TasteAndSmellFromMouth
    }

    public class Syndrome
    {
        public class DigestiveProps
        {
            public class PoopFrequency
            {
                private string timeOFDay;
                private string durationAndDifficulty;
                private List<poopStructure> poopStruct;
                private List<feelingAfterPoop> feelingAfterPoop;
                private List<generalDigestiveSymptoms> generalDigestiveSymptoms;
                private string notes;

                public string TimeOFDay
                {
                    get { return timeOFDay; }
                    set { timeOFDay = value; }
                }

                public string DurationAndDifficulty
                {
                    get { return durationAndDifficulty; }
                    set { durationAndDifficulty = value; }
                }

                public List<poopStructure> PoopStruct
                {
                    get { return poopStruct; }
                    set { poopStruct = value; }
                }

                public List<feelingAfterPoop> FeelingAfterPoop
                {
                    get { return feelingAfterPoop; }
                    set { feelingAfterPoop = value; }
                }

                public List<generalDigestiveSymptoms> GeneralDigestiveSymptoms
                {
                    get { return generalDigestiveSymptoms; }
                    set { generalDigestiveSymptoms = value; }
                }

                public string Notes
                {
                    get { return notes; }
                    set { notes = value; }
                }
            }
        }
    }
}
