const initialState = {
}

export default function ChapterReducer(state = initialState, action) {
    switch (action.type) {
        case 'chapter/selectChapter': {
            return {
                ...state,
                selectedChapter: action.payload
            }
        }
        default:
            return state
    }
}