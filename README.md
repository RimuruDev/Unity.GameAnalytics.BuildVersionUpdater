# Unity GameAnalytics Build Version Updater

[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

## Overview

**Unity GameAnalytics Build Version Updater** — это Editor хелпер, который автоматически обновляет версию билда в `GameAnalytics Settings.asset` перед каждым билдом. Скрипт упрощает процесс управления версиями, гарантируя, что версия билда, указанная в проекте, синхронизируется с конфигурацией GameAnalytics.

## Как это работает

Скрипт реализует интерфейс `IPreprocessBuildWithReport`, который позволяет выполнить кастомную логику до начала процесса сборки. В данном случае скрипт обновляет поле `Build` в `Settings.asset`, основываясь на текущем значении версии проекта (`Application.version`). Это гарантирует, что версия билда GameAnalytics всегда будет актуальной для каждого создаваемого билда.

## Особенности

- Автоматическое обновление поля `Build` в `Settings.asset` перед каждым билдом.
- Основано на значении версии проекта (`Application.version`).
- Работает для всех платформ Unity.
- Простая установка и использование.
- Поддержка Unity 2022+.

## Установка

1. Скачайте/скопируйте скрипт в любую папку Unity.
2. Убедитесь, что у вас есть настроенный `Settings.asset` от GameAnalytics в пути: `Assets/Resources/GameAnalytics/Settings.asset`.
3. После этого скрипт автоматически будет обновлять версию перед каждым билдом.

⚠️ Важно! Не помещать в папку Plugins! ⚠️

## Как использовать

1. Установите версию проекта в Unity в настройках:
   - **Edit -> Project Settings -> Player -> Other Settings -> Version**.

2. Когда вы запускаете процесс сборки, скрипт автоматически обновит поле `Build` в GameAnalytics `Settings.asset`, чтобы оно соответствовало версии проекта.

3. Версия будет обновляться автоматически перед каждым билдом без необходимости дополнительных действий с вашей стороны.

## Пример

Если версия вашего проекта установлена как `3.8.40.221`, то перед билдом в GameAnalytics Settings версия `Build` будет обновлена до `3.8.40.221` во всех доступных конфигурациях (например, WebGL, Android и т.д.).

![icon](https://github.com/user-attachments/assets/12e13e2f-375a-458b-b74b-e066df13be5d)


## Автор

Автор скрипта: **RimuruDev**  
[GitHub](https://github.com/RimuruDev)

## Лицензия

Этот проект лицензирован на условиях лицензии MIT. Подробности см. в файле [LICENSE](LICENSE).
