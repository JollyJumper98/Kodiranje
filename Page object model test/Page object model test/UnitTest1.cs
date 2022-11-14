using Page_object_model_test.Helper;
using Page_object_model_test.Page;

namespace Page_object_model_test
{
    public class Tests:Base 
    {
       PracticeForm form;

        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterName("Dusan");
            form.EnterLastName("Dobric");
            form.EnterEmail("vladimirputin@gmail.com");
            form.SelectGender();
            form.EnterMobile("0631355555");
            form.EnterSubjects();
            form.EnterHobby("hobby");
            form.PressButton();

            
        }
    }
}