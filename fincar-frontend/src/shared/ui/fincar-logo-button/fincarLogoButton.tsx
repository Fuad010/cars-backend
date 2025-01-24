import { FC } from 'react'
import styles from './fincarLogoButton.module.css'
import { NavLink } from 'react-router-dom'
import clsx from 'clsx'

type ButtonTheme = 'orange' | 'white'

interface IButton {
    readonly fontColor: ButtonTheme;
}

export const FincarLogoButton: FC<IButton> = (props) => {
    const {
        fontColor,
    } = props
    return (
        <NavLink to='/'
            className={clsx(
                styles.fincarButton,
                fontColor === 'orange' && styles.orange,
                fontColor === 'white' && styles.white
            )}
        >
            Fincar
        </NavLink>
    );
}