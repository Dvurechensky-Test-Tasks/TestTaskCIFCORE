<p align="center">✨Dvurechensky✨</p>

<h1 align="center"> Тестовое задание компании 🌟 ЦИФКОР 🌟</h1>

<p align="center">
    <p align="center">
        <a href="https://sites.google.com/view/dvurechensky" target="_blank"><img alt="Static Badge" src="https://img.shields.io/badge/Dvurechensky-Nikolay-blue"></a>
        <img src="https://shields.dvurechensky.pro/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white">
        <img src="https://shields.dvurechensky.pro/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white">
    </p>
</p>

<div align="center" style="margin: 20px 0; padding: 10px; background: #1c1917; border-radius: 10px;">
  <strong>🌐 Язык: </strong>
  
  <span style="color: #F5F752; margin: 0 10px;">
    ✅ 🇷🇺 Русский (текущий)
  </span>
  | 
  <a href="./README.md" style="color: #0891b2; margin: 0 10px;">
    🇺🇸 English
  </a>
</div>

---

# ✨ Оглавление

- [✨ Оглавление](#-оглавление)
  - [📕 ВНИМАНИЕ 📕](#-внимание-)
  - [Технологии 👤](#технологии-)
    - [Пояснения 📗](#пояснения-)
  - [Информация от компании 🌁](#информация-от-компании-)
  - [Информация от меня 🌊](#информация-от-меня-)
  - [👀 Сборка 👀](#-сборка-)

## 📕 ВНИМАНИЕ 📕

- В задаче я не увидел каков должен быть BUILD, под какие системы собрать сборки, поэтому счёл не собирать SDK и не класть их в репозиторий

## Технологии 👤

- 📋 UniTask
- 📋 Addressables
- 📋 Zenject
- ✂️ UniRx - так и не удалось его использовать

### Пояснения 📗

- Есть `отдельный ObjectPool` который призван централизованно отдавать объекты таблицам.Использование Addressables для кэширования объектов также вписывается в эту логику.
- Использую контроллеры для управления состоянием и логикой взаимодействия между компонентами, что вполне соответствует паттерну `MVC`
- `MVP` в моём контексте тоже возможно: контроллеры (как модели) взаимодействуют с представлениями, обновляя их в зависимости от данных. Разделение ответственности между логикой и интерфейсом также соблюдается.
- **`Zenject (Factory/Pool)`** - Активно использую Zenject для инъекции зависимостей. Инъекции позволяют отделить логику создания объектов от их использования, что идеально подходит для использования паттернов типа Factory.

- 📘 В дополнении я сделал кеширование иконок погоды после первой загрузки их с сервера

## Информация от компании 🌁

[Текст тестового задания](<Media/Тестовое задание Cifkor 17.02.2025.pdf>)

## Информация от меня 🌊

💨 Я своё понимание этого задания постарался описать в этом изображении❕

![alt text](Media/plan.png)

💨 Видео

<p align="center">
    <img src="Media/previewVideo.gif" height="100%" width="100%">
</p>

## 👀 Сборка 👀

- После удаления папки `Library` перед релизом сбрасывается выбор платформы под которую создавался проект.

![alt text](Media/build_1.png)
![alt text](Media/build_2.png)

<p align="center">✨Dvurechensky✨</p>
