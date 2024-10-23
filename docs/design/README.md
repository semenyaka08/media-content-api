# Проєктування бази даних

## Модель бізнес-об'єктів

@startuml

left to right direction


entity User <<ENTITY>> #900020
entity User.id <<NUMBER>> #C41E3A
entity User.first_name <<TEXT>> #C41E3A
entity User.last_name <<TEXT>> #C41E3A
entity User.email <<TEXT>> #C41E3A
entity User.password <<TEXT>> #C41E3A

User.id -d-* User
User.first_name -d-* User
User.last_name -d-* User
User.email -d-* User
User.password -d-* User


entity MediaContent <<ENTITY>> #990099
entity MediaContent.id <<NUMBER>> #CC00CC
entity MediaContent.a <<A>> #CC00CC

MediaContent.id -d-* MediaContent
MediaContent.a -d-* MediaContent


entity Role <<ENTITY>> #FFFF00
entity Role.id <<NUMBER>> #FFFF66
entity Role.name <<TEXT>> #FFFF66
entity Role.description <<TEXT>> #FFFF66


Role.id -l-* Role
Role.name -l-* Role
Role.description -l-* Role

entity Permission <<ENTITY>> #606060
entity Permission.id <<NUMBER>> #A0A0A0
entity Permission.name <<TEXT>> #A0A0A0


Permission.id -l-* Permission
Permission.name -l-* Permission


entity Source <<ENTITY>> #FF6500
entity Source.id <<NUMBER>> #FFBD73
entity Source.name <<TEXT>> #FFBD73
entity Source.url <<TEXT>> #FFBD73

Source.id --* Source 
Source.name -r-* Source 
Source.url -u-* Source


entity AnalysisResult <<ENTITY>> #80FF00
entity AnalysisResult.id <<NUMBER>> #B2FF66
entity AnalysisResult.created_at <<DATE>> #B2FF66
entity AnalysisResult.title <<TEXT>> #B2FF66
entity AnalysisResult.description <<TEXT>> #B2FF66
entity AnalysisResult.body <<TEXT>> #B2FF66

AnalysisResult.id -u-* AnalysisResult
AnalysisResult.created_at -u-* AnalysisResult
AnalysisResult.title -u-* AnalysisResult
AnalysisResult.description -u-* AnalysisResult
AnalysisResult.body -u-* AnalysisResult


entity Tag <<ENTITY>> #08C2FF 
entity Tag.name <<TEXT>> #BCF2F6 
entity Tag.id <<NUMBER>> #BCF2F6

Tag.id -u-* Tag 
Tag.name -u-* Tag


entity RolePermission <<ENTITY>>


entity MediaContentSource <<ENTITY>>
entity MediaContentSource.id <<NUMBER>>

MediaContentSource.id --* MediaContentSource


entity MediaContentAnalysisResult <<ENTITY>>
entity MediaContentAnalysisResult.id <<NUMBER>>

MediaContentAnalysisResult.id --* MediaContentAnalysisResult


entity MediaContentTag <<ENTITY>>
entity MediaContentTag.id <<NUMBER>>

MediaContentTag.id --* MediaContentTag


entity AnalysisResultTag <<ENTITY>>
entity AnalysisResultTag.id <<NUMBER>>

AnalysisResultTag.id -u-* AnalysisResultTag


entity SourceTag <<ENTITY>>
entity SourceTag.id <<NUMBER>>

SourceTag.id -u-* SourceTag


User "1.1" -- "0.*" MediaContent
User "1.1" -- "0.*" AnalysisResult

User "1.*" -- "1.1" Role


Role "1.1" -- "0.*" RolePermission

RolePermission "1.*" -- "1.1" Permission

MediaContent "1.1" -- "0.*" MediaContentSource
MediaContentSource "1.*" -- "1.1" Source

MediaContent "1.1" -- "0.*" MediaContentAnalysisResult
MediaContentAnalysisResult "1.*" -- "1.1" AnalysisResult

MediaContent "1.1" -- "0.*" MediaContentTag
MediaContentTag "1.*" -- "1.1" Tag

AnalysisResult "1.1" -- "0.*" AnalysisResultTag
AnalysisResultTag "1.*" -- "1.1" Tag

Source "1.1" -- "0.*" SourceTag
SourceTag "1.*" -- "1.1" Tag

@enduml


- ER-модель
- реляційна схема

