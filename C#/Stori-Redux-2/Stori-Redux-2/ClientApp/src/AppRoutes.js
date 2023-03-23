import Chapter from "./features/Chapter/Chapter";
import BookPage from './features/BookPage/BookPage';
import ChapterText from './features/ChapterText/ChapterText';

const AppRoutes = [
  {
    index: true,
    element: <BookPage />
  },
  {
    path: '/chapter',
    element: <Chapter />
  },
  {
      path: '/chapterText',
    element: <ChapterText />
  },
  {
    path: '/books',
    element: <BookPage />
  }
];

export default AppRoutes;
