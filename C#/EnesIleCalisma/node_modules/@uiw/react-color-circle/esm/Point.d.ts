import { SwatchRectRenderProps, SwatchProps } from '@uiw/react-color-swatch';
interface PointProps extends SwatchRectRenderProps {
    rectProps?: SwatchProps['rectProps'];
}
export default function Point({ style, title, checked, color, onClick, rectProps }: PointProps): JSX.Element;
export {};
