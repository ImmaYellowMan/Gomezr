using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    //private Question currentOpinion1;
    //private Question currentOpinion2;
    //private Question currentOpinion3;
    //private Question currentOpinion4;

    [SerializeField]
    private Text factText;

    //[SerializeField]
   // private Text opinionText1;
  
    //[SerializeField]
   // private Text opinionText2;

    //[SerializeField]
   // private Text opinionText3;

    //[SerializeField]
   //private Text opinionText4;



    [SerializeField]
    private float timeBetweenQuestions = 1f;

    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;
    [SerializeField]
    private Animator animator;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        //for debiugging purposes only!
        // Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);

    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        //int randomAnswserIndex = randomQuestionIndex;
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        //currentOpinion1 = unansweredQuestions[randomQuestionIndex];
        //currentOpinion2 = unansweredQuestions[randomQuestionIndex];
        //currentOpinion3 = unansweredQuestions[randomQuestionIndex];
        //currentOpinion4 = unansweredQuestions[randomQuestionIndex];


        factText.text = currentQuestion.fact;
        //opinionText1.text = currentOpinion1.opinion1;
       //opinionText2.text = currentOpinion2.opinion2;
        //opinionText3.text = currentOpinion3.opinion3;
        //opinionText4.text = currentOpinion4.opinion4;

        unansweredQuestions.RemoveAt(randomQuestionIndex);
        //if (currentQuestion.isTrue)
       // {
           // trueAnswerText.text = "CORRECT";
           // falseAnswerText.text = "FALSE";
       // }
       // else
       // {
            //trueAnswerText.text = "WRONG";
            //falseAnswerText.text = "CORRECT";
       // }
        if (currentQuestion.answer1)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "FALSE";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }

        if (currentQuestion.answer2)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "FALSE";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }

        if (currentQuestion.answer3)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "FALSE";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }

        if (currentQuestion.answer4)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "FALSE";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void UserSelectAnswer1()
    {
        
        if (currentQuestion.answer1)
        {
            animator.SetTrigger("True");
            Debug.Log("Correct");
        }
        else
        {
            animator.SetTrigger("False");
            Debug.Log("False");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectAnswer2()
    {
       
        if (currentQuestion.answer2)
        {
            animator.SetTrigger("True");
            Debug.Log("Correct");
        }
        else
        {
            animator.SetTrigger("False");
            Debug.Log("False");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectAnswer3()
    {
        
        if (currentQuestion.answer3)
        {
            animator.SetTrigger("True");
            Debug.Log("Correct");
        }
        else
        {
            animator.SetTrigger("False");
            Debug.Log("False");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectAnswer4()
    {
        
        if (currentQuestion.answer4)
        {
            animator.SetTrigger("True");
            Debug.Log("Correct");
        }
        else
        {
            animator.SetTrigger("False");
            Debug.Log("False");
        }

        StartCoroutine(TransitionToNextQuestion());
    }



}
