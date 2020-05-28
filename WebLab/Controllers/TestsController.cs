using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebLab.Controllers
{
    public class TestsController : Controller
    {
        /*
         * <summary>
         * Processing results of the "easy test"
         * </summary>
        */
        public IActionResult Test1()
        {
            var total = 0;
            if (Request.Method == "POST")
            {
                const int QuestionsCount = 30;
                // Questions
                if (Request.Form.TryGetValue("Q1", out var Q1Value) && Q1Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q2", out var Q2Value) && Q2Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q3", out var Q3Value) && Q3Value.Contains("A1") && Q3Value.Contains("A2") && Q3Value.Contains("A4")
                    && !Q3Value.Contains("A3") && !Q3Value.Contains("A5"))
                    ++total;

                if (Request.Form.TryGetValue("Q4", out var Q4Value) && Q4Value.Contains("A2") && Q4Value.Contains("A3") && Q4Value.Contains("A5")
                    && !Q4Value.Contains("A1") && !Q4Value.Contains("A4"))
                    ++total;

                if (Request.Form.TryGetValue("Q5", out var Q5Value) && Q5Value.Contains("A1") && Q5Value.Contains("A3")
                    && !Q5Value.Contains("A2") && !Q5Value.Contains("A4") )
                    ++total;

                if (Request.Form.TryGetValue("Q6", out var Q6Value) && Q6Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q7", out var Q7Value) && Q7Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q8", out var Q8Value) && Q8Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q9", out var Q9Value) && Q9Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q10", out var Q10Value) && Q10Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q11", out var Q11Value) && Q11Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q12", out var Q12Value) && Q12Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q13", out var Q13Value) && Q13Value.Contains("A1") && Q13Value.Contains("A4")
                   && !Q13Value.Contains("A2") && !Q13Value.Contains("A3"))
                    ++total;

                if (Request.Form.TryGetValue("Q14", out var Q14Value) && Q14Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q15", out var Q15Value) && Q15Value.Contains("A1") && Q15Value.Contains("A2") && Q15Value.Contains("A4")
                    && Q15Value.Contains("A5") && Q15Value.Contains("A6")
                   && !Q15Value.Contains("A3") && !Q15Value.Contains("A7"))
                    ++total;

                if (Request.Form.TryGetValue("Q16", out var Q16Value) && Q16Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q17", out var Q17Value) && Q17Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q18", out var Q18Value) && Q18Value.Contains("A1") && Q18Value.Contains("A3") && Q18Value.Contains("A4")
                          && Q18Value.Contains("A7")
                         && !Q18Value.Contains("A2") && !Q18Value.Contains("A5") && !Q18Value.Contains("A6"))
                    ++total;

                if (Request.Form.TryGetValue("Q19", out var Q19Value) && Q19Value.Contains("A3") && Q19Value.Contains("A5")
                  && !Q19Value.Contains("A1") && !Q19Value.Contains("A2") && !Q19Value.Contains("A4"))
                    ++total;

                if (Request.Form.TryGetValue("Q20", out var Q20Value) && Q20Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q21", out var Q21Value) && Q21Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q22", out var Q22Value) && Q22Value.Contains("A2") && Q22Value.Contains("A3")
                  && !Q22Value.Contains("A1") && !Q22Value.Contains("A4") && !Q22Value.Contains("A5"))
                    ++total;

                if (Request.Form.TryGetValue("Q23", out var Q23Value) && Q23Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q24", out var Q24Value) && Q24Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q25", out var Q25Value) && Q25Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q26", out var Q26Value) && Q26Value.Contains("A1") && Q26Value.Contains("A3") && Q26Value.Contains("A4")
                  && !Q26Value.Contains("A2"))
                    ++total;

                if (Request.Form.TryGetValue("Q27", out var Q27Value) && Q27Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q28", out var Q28Value) && Q28Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q29", out var Q29Value) && Q29Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q30", out var Q30Value) && Q30Value == "A2")
                    ++total;

                List<int> RightsAnswersAndAllAnswers = new List<int>();
                RightsAnswersAndAllAnswers.Add(total);
                RightsAnswersAndAllAnswers.Add(QuestionsCount);
                
                return View("Result", RightsAnswersAndAllAnswers);
            }
            else
              return View();
        }
        /*
         * <summary>
         * Processing results of the "medium test"
         * </summary>
        */
        public IActionResult Test2()
        {
            var total = 0;
            if (Request.Method == "POST")
            {
                const int QuestionsCount = 30;

                // Questions
                if (Request.Form.TryGetValue("Q1", out var Q1Value) && Q1Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q2", out var Q2Value) && Q2Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q3", out var Q3Value)
                    && Q3Value.Contains("A1") 
                    && Q3Value.Contains("A3") 

                    && !Q3Value.Contains("A2") 
                    && !Q3Value.Contains("A4")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q4", out var Q4Value) && Q4Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q5", out var Q5Value) && Q5Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q6", out var Q6Value)
                && Q6Value.Contains("A1")
                && Q6Value.Contains("A2")
                && Q6Value.Contains("A3")
                && Q6Value.Contains("A6")
                && Q6Value.Contains("A7")
                && Q6Value.Contains("A9")

                && !Q6Value.Contains("A4")
                && !Q6Value.Contains("A5")
                && !Q6Value.Contains("A8")
                )
                    ++total;

                if (Request.Form.TryGetValue("Q7", out var Q7Value) && Q7Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q8", out var Q8Value)
                    && Q8Value.Contains("A1")
                    && Q8Value.Contains("A4")

                    && !Q8Value.Contains("A2")
                    && !Q8Value.Contains("A3")
                    && !Q8Value.Contains("A5")
                    )
                       ++total;

                if (Request.Form.TryGetValue("Q9", out var Q9Value) && Q9Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q10", out var Q10Value)
                   && Q10Value.Contains("A2")
                   && Q10Value.Contains("A4")
                   && Q10Value.Contains("A7")

                   && !Q10Value.Contains("A1")
                   && !Q10Value.Contains("A3")
                   && !Q10Value.Contains("A5")
                   && !Q10Value.Contains("A6")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q11", out var Q11Value)
                   && Q11Value.Contains("A1")
                   && Q11Value.Contains("A4")
                   && Q11Value.Contains("A5")
                   && Q11Value.Contains("A7")

                   && !Q11Value.Contains("A2")
                   && !Q11Value.Contains("A3")
                   && !Q11Value.Contains("A6")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q12", out var Q12Value) && Q12Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q13", out var Q13Value) && Q13Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q14", out var Q14Value)
                   && Q14Value.Contains("A3")
                   && Q14Value.Contains("A5")

                   && !Q14Value.Contains("A1")
                   && !Q14Value.Contains("A2")
                   && !Q14Value.Contains("A4")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q15", out var Q15Value)
                   && Q15Value.Contains("A1")
                   && Q15Value.Contains("A3")
                   && Q15Value.Contains("A5")

                   && !Q15Value.Contains("A2")
                   && !Q15Value.Contains("A4")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q16", out var Q16Value) && Q16Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q17", out var Q17Value)
                   && Q17Value.Contains("A1")
                   && Q17Value.Contains("A5")

                   && !Q17Value.Contains("A2")
                   && !Q17Value.Contains("A3")
                   && !Q17Value.Contains("A4")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q18", out var Q18Value) && Q18Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q19", out var Q19Value) && Q19Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q20", out var Q20Value) && Q20Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q21", out var Q21Value)
                  && Q21Value.Contains("A1")
                  && Q21Value.Contains("A3")
                  && Q21Value.Contains("A5")

                  && !Q21Value.Contains("A2")
                  && !Q21Value.Contains("A4")
                  )
                    ++total;

                if (Request.Form.TryGetValue("Q22", out var Q22Value)
                   && Q22Value.Contains("A1")
                   && Q22Value.Contains("A3")
                   && Q22Value.Contains("A5")

                   && !Q22Value.Contains("A2")
                   && !Q22Value.Contains("A4")
                   && !Q22Value.Contains("A6")
                   )
                    ++total;

                if (Request.Form.TryGetValue("Q23", out var Q23Value) && Q23Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q24", out var Q24Value) && Q24Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q25", out var Q25Value) && Q25Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q26", out var Q26Value) && Q26Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q27", out var Q27Value)
                    && Q27Value.Contains("A1")
                    && Q27Value.Contains("A3")
                    && Q27Value.Contains("A6")
                    && Q27Value.Contains("A7")
                    && Q27Value.Contains("A8")

                    && !Q27Value.Contains("A2")
                    && !Q27Value.Contains("A4")
                    && !Q27Value.Contains("A5")
                    && !Q27Value.Contains("A9")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q28", out var Q28Value) && Q28Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q29", out var Q29Value) && Q29Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q30", out var Q30Value)
                   && Q30Value.Contains("A3")
                   && Q30Value.Contains("A5")
                   && Q30Value.Contains("A6")

                   && !Q30Value.Contains("A1")
                   && !Q30Value.Contains("A2")
                   && !Q30Value.Contains("A4")
                   && !Q30Value.Contains("A7")
                   )
                    ++total;

                List<int> RightsAnswersAndAllAnswers = new List<int>();
                RightsAnswersAndAllAnswers.Add(total);
                RightsAnswersAndAllAnswers.Add(QuestionsCount);

                return View("Result", RightsAnswersAndAllAnswers);
            }
            else
                return View();
        }
        /*
          * <summary>
          * Processing results of the "containers test"
          * </summary>
         */
        public IActionResult Test3()
        {
            var total = 0;
            if (Request.Method == "POST")
            {

                const int QuestionsCount = 20;
                // Questions
                if (Request.Form.TryGetValue("Q1", out var Q1Value)
                    && Q1Value.Contains("A2")
                    && Q1Value.Contains("A3")
                    && Q1Value.Contains("A4")
                    && Q1Value.Contains("A5")
                    && Q1Value.Contains("A7")
                    && Q1Value.Contains("A9")

                    && !Q1Value.Contains("A1")
                    && !Q1Value.Contains("A6")
                    && !Q1Value.Contains("A8")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q2", out var Q2Value) && Q2Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q3", out var Q3Value) && Q3Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q4", out var Q4Value)
                    && Q4Value.Contains("A4")
                    && Q4Value.Contains("A6")
                    && Q4Value.Contains("A7")
                    && Q4Value.Contains("A9")

                    && !Q4Value.Contains("A1")
                    && !Q4Value.Contains("A2")
                    && !Q4Value.Contains("A3")
                    && !Q4Value.Contains("A5")
                    && !Q4Value.Contains("A8")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q5", out var Q5Value) && Q5Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q6", out var Q6Value) && Q6Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q7", out var Q7Value) && Q7Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q8", out var Q8Value) && Q8Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q9", out var Q9Value) && Q9Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q10", out var Q10Value)
                    && Q10Value.Contains("A2")
                    && Q10Value.Contains("A5")

                    && !Q10Value.Contains("A1")
                    && !Q10Value.Contains("A3")
                    && !Q10Value.Contains("A4")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q11", out var Q11Value) && Q11Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q12", out var Q12Value)
                    && Q12Value.Contains("A1")
                    && Q12Value.Contains("A5")
                    && Q12Value.Contains("A8")

                    && !Q12Value.Contains("A2")
                    && !Q12Value.Contains("A3")
                    && !Q12Value.Contains("A4")
                    && !Q12Value.Contains("A6")
                    && !Q12Value.Contains("A7")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q13", out var Q13Value) && Q13Value == "A5")
                    ++total;

                if (Request.Form.TryGetValue("Q14", out var Q14Value) && Q14Value == "A1")
                    ++total;

                if (Request.Form.TryGetValue("Q15", out var Q15Value) && Q15Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q16", out var Q16Value)
                    && Q16Value.Contains("A2")
                    && Q16Value.Contains("A5")
                    && Q16Value.Contains("A6")

                    && !Q16Value.Contains("A1")
                    && !Q16Value.Contains("A3")
                    && !Q16Value.Contains("A4")
                    && !Q16Value.Contains("A7")
                    && !Q16Value.Contains("A8")
                    )
                    ++total;

                if (Request.Form.TryGetValue("Q17", out var Q17Value) && Q17Value == "A3")
                    ++total;

                if (Request.Form.TryGetValue("Q18", out var Q18Value) && Q18Value == "A2")
                    ++total;

                if (Request.Form.TryGetValue("Q19", out var Q19Value) && Q19Value == "A4")
                    ++total;

                if (Request.Form.TryGetValue("Q20", out var Q20Value) && Q20Value == "A3")
                    ++total;

                List<int> RightsAnswersAndAllAnswers = new List<int>();
                RightsAnswersAndAllAnswers.Add(total);
                RightsAnswersAndAllAnswers.Add(QuestionsCount);

                return View("Result", RightsAnswersAndAllAnswers);
            }
            else
                return View();
        }
        /*
       * <summary>
       * For writing result
       * </summary>
      */
        public IActionResult Result()
        {
            if (Request.Method == "GET")
                Redirect("/");
            
            return View();
        }

        
    }
}
