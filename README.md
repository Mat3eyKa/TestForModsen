# TestForModsen
Приивет!
Для работы с этим сервисом тебе надо сделать несколько шагов:
1. Запустить проект 
2. Получить токен авторизации
2.1. Нажимаем на Вкладку Auth(Post)
2.2. Нажимаем на кнопку "Try it out"
2.3. Вставляем в "Request body" вот это(удалив содержимое):
{
   "userName": "Jay",
   "password": "123456"
}
2.4. Нажимаем на кнопку "Execute"
2.5. Копируем "token" на подобии вот этого:
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IkpheSIsIm5iZiI6MTY3MDUxMDU3OSwiZXhwIjoxNjcwNTE0MTc5LCJpYXQiOjE2NzA1MTA1NzksImlzcyI6IkpXVEF1dGhlbnRpY2F0aW9uU2VydmVyIiwiYXVkIjoiSldUU2VydmljZUNsaWVudCJ9.k7OTPXv61yw__eoq2IW0AQzgISRBEEpp5TgzzwmVkys
3. Авторизируем пользователя
3.1. Нажимаем на кнопку "Authorize"
3.2. Пишем: Bearer(пробел)(вставляем скопрированный токен из пункта 2.5.)
3.3. Нажимаем на кнопку "Authorize"
3.4. Закрываем окно 
Все пользователь авторизован и ты можешь поьзоваться всеми запросами из вкладки "Home"
НЕБЕЛЬШОЕ УТОЧНЕНИИЕ:
Проект сделан так, а не иначе тк я предпологал что это будет как отдельный модуль, которым может пользоваться только авторезированный пользователь
и вся авторизации будет происходить в другом модуле
