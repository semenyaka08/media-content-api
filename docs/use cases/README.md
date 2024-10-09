# Модель прецедентів

## Загальна діаграма прецедентів

**На рис. 1 зображена загальна діаграма прецедентів та їх основні можливості.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

    

@enduml

**Рис. 1** Загальна діаграма прецедентів

</center>

## Діаграма використання для Гостя

**На рис. 2 зображені усі можливості гостя.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

    

@enduml

**Рис. 2** Діаграма можливостей гостя

</center>

## Діаграма використання для Користувача

**На рис. 3 зображені усі можливості користувача.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

    

@enduml

**Рис. 3** Діаграма можливостей користувача

</center>

## Діаграма використання для Технічного експерта

**На рис. 4 зображені усі можливості технічного експерта.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

actor "Технічний експерт" as TechnicalExpert #lightyellow

usecase "<b>User management</b>\nКерування користувачами" as UserManagement 

usecase "<b>DeleteUser</b>\nВидалення користувача" as DeleteUser #lightblue
usecase "<b>UserRolePromote</b>\nПідвищення ролі користувача" as UserRolePromote #lightblue

TechnicalExpert --> UserManagement

DeleteUser .u.> UserManagement : "extends"
UserRolePromote .u.> UserManagement : "extends"    

@enduml

**Рис. 4** Діаграма можливостей технічного експерта

</center>
