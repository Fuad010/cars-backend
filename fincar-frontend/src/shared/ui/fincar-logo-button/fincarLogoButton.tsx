import { FC } from 'react'
import styles from './fincarLogoButton.module.css'
import { NavLink } from 'react-router-dom'
import clsx from 'clsx'

type ButtonTheme = 'yellow' | 'white'

interface IButton {
    readonly fontColor: ButtonTheme;
}

export const FincarLogoButton: FC<IButton> = (props) => {
    const {
        fontColor,
    } = props
    return (
        <NavLink to='/home'
            className={clsx(
                styles.fincarButton,
                fontColor === 'yellow' && styles.yellow,
                fontColor === 'white' && styles.white
            )}
        >
            Fincar
        </NavLink>
    );
}