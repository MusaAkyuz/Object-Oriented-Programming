import NavbarMenuReducer from './features/NavbarMenu/NavbarMenuSlice'
import BookPageReducer from './features/BookPage/BookPageSlice'
import ChapterReducer from './features/Chapter/ChapterSlice'

import { combineReducers } from 'redux'

const rootReducer = combineReducers({
    // Define a top-level state field named `todos`, handled by `todosReducer`
    TextSettings: NavbarMenuReducer,
    AllBooks: BookPageReducer,
    Chapters: ChapterReducer
})

export default rootReducer
