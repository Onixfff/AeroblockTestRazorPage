// Получаем все элементы input на странице
var allInputs = document.getElementsByTagName('input');

// Создаем пустой массив для хранения checkbox
var checkboxes = [];

// Проходим по всем элементам input и проверяем их тип
for (var i = 0; i < allInputs.length; i++) {
    if (allInputs[i].type === 'checkbox') {
        checkboxes.push(allInputs[i]);
        // Добавляем обработчик события для каждого чекбокса
        allInputs[i].addEventListener('click', function (event) {
            // Предотвращаем изменение значения чекбокса
            event.preventDefault();
        });
    }
}

// Теперь массив checkboxes содержит все элементы checkbox на странице
console.log(checkboxes);