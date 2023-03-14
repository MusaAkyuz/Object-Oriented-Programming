
const initialState = {
    textSettings: {
        textColor: 'white',
        speed: 50
    }
}

export default function NavbarMenuReducer(state = initialState, action) {
    switch (action.type) {
        case 'navbarmenu/textSettingsChange': {
            //console.log("girdi")
            //console.log(action.payload)
            return {
                ...state,
                textSettings: {
                    textColor: action.payload[0],
                    speed: action.payload[1]
                }
            }
        }
        default:
            return state
    }
}