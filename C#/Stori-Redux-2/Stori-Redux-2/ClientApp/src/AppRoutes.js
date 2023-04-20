import Chapter from "./features/Chapter/Chapter";
import BookPage from './features/BookPage/BookPage';
import ChapterText from './features/ChapterText/ChapterText';
import Welcome from './features/Welcome/Welcome';
import Art from './features/Art/Art';
import Login from './features/Login/Login';

const AppRoutes = [
  {
    index: true,
    element: <Welcome />
  },
  {
    path: '/chapter',
    element: <Chapter />
  },
  {
    path: '/art',
    element: <Art />
  },
  {
    path: '/chapterText',
    element: <ChapterText />
    },
    {
        path: '/login',
        element: <Login />
    },
  {
    path: '/books',
    element: <BookPage />
  }
];

export default AppRoutes;
