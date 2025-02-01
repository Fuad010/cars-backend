import { FincarLogoButton } from 'shared/ui/fincar-logo-button/fincarLogoButton'
import styles from './footer.module.css'
import githubLogo from 'shared/assets/icons/githubLogo.svg'
import linkedinLogo from 'shared/assets/icons/linkedinLogo.svg'
import { Link } from 'react-router-dom'

export const Footer = () => {
    return(
        <div className={styles.wrapper}>
            <div className={styles.container}>
                <div className={styles.leftContent}>
                    <FincarLogoButton fontColor='white' />
                </div>
                <div className={styles.rightContent}>
                    <p>Social networks</p>
                    <div className={styles.socialContainer}>
                        <div>
                            <Link target='blank' to="https://github.com/Fuad010/fincar-project">
                                <img src={githubLogo} alt="githubLogo" />
                            </Link>
                        </div>
                        <div>
                            <Link target='blank' to="https://www.linkedin.com/in/fuadtopchiyev/">
                                <img src={linkedinLogo} alt="linkedinLogo" />
                            </Link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}