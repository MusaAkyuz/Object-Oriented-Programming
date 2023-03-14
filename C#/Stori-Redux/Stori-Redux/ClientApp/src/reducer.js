import NavbarMenuReducer from './features/NavbarMenu/NavbarMenuSlice'
import BookPageReducer from './features/BookPage/BookPageSlice'

import { combineReducers } from 'redux'

const rootReducer = combineReducers({
    // Define a top-level state field named `todos`, handled by `todosReducer`
    textSettings: NavbarMenuReducer,
    books: BookPageReducer
})

export default rootReducer
