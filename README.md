Отсюда:
https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-3.1&tabs=visual-studio

`Models/`
Модели: классы, представляющие данные в приложении. Классы модели используют логику проверки, которая позволяет применять бизнес-правила к этим данным. Как правило, объекты модели извлекают и сохраняют состояние модели в базе данных.

`Views/`
Представления: компоненты, которые формируют пользовательский интерфейс приложения. Как правило, в пользовательском интерфейсе отображаются данные модели.

`Controllers/`
Контроллеры: классы, которые обрабатывают запросы браузера. Они извлекают данные модели и вызывают шаблоны представлений, которые возвращают ответ. В приложении MVC представление служит только для отображения информации. Обработку введенных данных, формирование ответа и взаимодействие с пользователем обеспечивает контроллер. Например, контроллер обрабатывает данные маршрута и значения строки запроса, после чего передает эти значения в модель. Модель может использовать эти значения для выполнения запросов к базе данных. Например, http://localhost:5000/Home/Privacy содержит данные маршрута для Home (контроллер) и метода действия Privacy (вызывает контроллер home). http://localhost:5000/Movies/Edit/5 — это запрос на редактирование фильма с идентификатором 5 с использованием контроллера movie. Данные маршрута описаны далее в этом руководстве.