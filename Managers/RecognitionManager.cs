using se.smartid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EleWise.ELMA.SmartEngineIntegration.Managers
{
    public class RecognitionManager
    {
        static string config_path = Environment.CurrentDirectory + @"\Files\bundle_full_server.zip";
        static RecognitionEngine engine;
        static SmartIdSampleCsReporter reporter;

        private const string default_document_types = "rus.passport.national";
        private static RecognitionManager instance;

        public RecognitionManager()
        {
            engine = new RecognitionEngine(config_path);
            reporter = new SmartIdSampleCsReporter();
        }

        public static RecognitionManager Instance()
        {
            if(instance == null)
            {
                instance = new RecognitionManager(); 
            }
            return instance;
        }

        static Dictionary<string, string> OutputRecognitionResult(RecognitionResult recog_result)
        {
            var stringFields = new Dictionary<string, string>();

            StringVector string_field_names = recog_result.GetStringFieldNames();
            for (int i = 0; i < string_field_names.Count; i++)
            {
                StringField field = recog_result.GetStringField(string_field_names[i]);
                Utf16CharVector chars = field.GetValue().GetUtf16String();
                StringBuilder value = new StringBuilder();
                foreach (Char ch in chars)
                {
                    value.Append(ch);
                }
                stringFields.Add(field.GetName(), value.ToString());
            }

            return stringFields;
        }

        public List<Dictionary<string, string>> Recognition(List<string> images, string type)
        {
            if(type == null)
            {
                type = default_document_types;
            }
            var list = new List<Dictionary<string, string>>();
            foreach (var image in images)
            {

                try
                {
                    SessionSettings settings = engine.CreateSessionSettings();
                    settings.AddEnabledDocumentTypes(type);
                    RecognitionSession session = engine.SpawnSession(settings, reporter);
                    var recog_result = session.ProcessImageDataBase64(image);
                    var result = OutputRecognitionResult(recog_result);

                    recog_result.Dispose();
                    session.Dispose();
                    list.Add(result);
                }
                catch (Exception e)
                {
                    var result = new Dictionary<string, string>();
                    result.Add("Exception caught: {0}", e.Message);
                    list.Add(result);
                }

            }
            return list;
        }


        public List<List<string>> GetSupportedDocumentTypes()
        {          
            SessionSettings settings = engine.CreateSessionSettings();
            StringVector2d stringVector2ds = settings.GetSupportedDocumentTypes();

            List<List<string>> result = new List<List<string>>();
            foreach (var item in stringVector2ds)
            {
                List<string> items = new List<string>();
                foreach(var test in item)
                {
                    items.Add(test);
                }
                result.Add(items);
            }
            return result;
        }



        ~RecognitionManager()
        {
            engine.Dispose();
            reporter.Dispose();
        }
    }
    class SmartIdSampleCsReporter : ResultReporterInterface
    {
        public SmartIdSampleCsReporter() : base()
        {
        }
        public override void SnapshotRejected()
        {
        }

        public override void DocumentMatched(MatchResultVector match_results)
        {
        }

        public override void DocumentSegmented(SegmentationResultVector segmentation_results)
        {

        }

        public override void SnapshotProcessed(RecognitionResult recog_result)
        {
        }

        public override void SessionEnded()
        {
        }
    }

}

