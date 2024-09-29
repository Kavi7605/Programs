const questions = [
    {
        question: "1. What is the capital of France?",
        options: ["A. Paris", "B. London", "C. Rome", "D. Berlin"],
        correct: "A"
    },
    {
        question: "2. Which planet is known as the Red Planet?",
        options: ["A. Earth", "B. Mars", "C. Jupiter", "D. Venus"],
        correct: "B"
    },
    {
        question: "3. Who wrote 'Hamlet'?",
        options: ["A. Charles Dickens", "B. J.K. Rowling", "C. William Shakespeare", "D. Mark Twain"],
        correct: "C"
    },
    {
        question: "4. What is the largest ocean on Earth?",
        options: ["A. Atlantic Ocean", "B. Pacific Ocean", "C. Indian Ocean", "D. Southern Ocean"],
        correct: "B"
    }
];

let currentQuestionIndex = 0;
let userAnswers = [];

function displayQuestion(index) {
    const questionContainer = document.getElementById('question-container');
    const questionData = questions[index];
    
    let questionHtml = `<p>${questionData.question}</p>`;
    questionData.options.forEach((option, i) => {
        questionHtml += `
            <input type="radio" name="question${index}" value="${option.charAt(0)}" id="q${index}${i}">
            <label for="q${index}${i}">${option}</label><br>
        `;
    });
    
    questionContainer.innerHTML = questionHtml;
    
    if (userAnswers[index]) {
        document.querySelector(`input[name="question${index}"][value="${userAnswers[index]}"]`).checked = true;
    }

    document.getElementById('prevBtn').style.display = index === 0 ? 'none' : 'inline-block';
    document.getElementById('nextBtn').style.display = index === questions.length - 1 ? 'none' : 'inline-block';
    document.getElementById('submitBtn').style.display = index === questions.length - 1 ? 'inline-block' : 'none';
}

function nextQuestion() {
    const selectedAnswer = document.querySelector(`input[name="question${currentQuestionIndex}"]:checked`);
    if (selectedAnswer) {
        userAnswers[currentQuestionIndex] = selectedAnswer.value;
    } else {
        alert("Please select an answer before proceeding.");
        return;
    }

    if (currentQuestionIndex < questions.length - 1) {
        currentQuestionIndex++;
        displayQuestion(currentQuestionIndex);
    }
}

function prevQuestion() {
    if (currentQuestionIndex > 0) {
        currentQuestionIndex--;
        displayQuestion(currentQuestionIndex);
    }
}

function submitQuiz() {
    const selectedAnswer = document.querySelector(`input[name="question${currentQuestionIndex}"]:checked`);
    if (selectedAnswer) {
        userAnswers[currentQuestionIndex] = selectedAnswer.value;
    } else {
        alert("Please select an answer before submitting.");
        return;
    }

    let score = 0;
    for (let i = 0; i < questions.length; i++) {
        if (userAnswers[i] === questions[i].correct) {
            score++;
        }
    }

    const resultDiv = document.getElementById('result');
    resultDiv.innerHTML = `You scored ${score} out of ${questions.length}!`;

    if (score === questions.length) {
        resultDiv.innerHTML += `<br>Excellent! You got all answers correct!`;
    } else if (score > 0) {
        resultDiv.innerHTML += `<br>Good job! Try again for a perfect score!`;
    } else {
        resultDiv.innerHTML += `<br>Better luck next time!`;
    }
}

displayQuestion(currentQuestionIndex);
