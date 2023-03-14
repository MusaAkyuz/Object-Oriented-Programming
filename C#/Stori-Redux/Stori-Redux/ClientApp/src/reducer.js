import NavbarMenuReducer from './features/NavbarMenu/NavbarMenuSlice'

import { combineReducers } from 'redux'

const rootReducer = combineReducers({
    // Define a top-level state field named `todos`, handled by `todosReducer`
    textSettings: NavbarMenuReducer,
})

export default rootReducer
