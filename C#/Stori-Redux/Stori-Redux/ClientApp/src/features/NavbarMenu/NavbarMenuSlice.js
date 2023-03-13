const initialState = {
    textColor: 'white'
}

export default function NavbarMenuReducer(state = initialState, action) {
    switch (action.type) {
        case '/navbarmenu/textColorChange': {
            return {
                ...state,
                textColor: action.payload
            }
        }
        default:
            return state
    }
}